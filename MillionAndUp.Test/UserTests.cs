
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using MillionAndUp.Data;
using MillionAndUp.Domain.Models;
using NUnit.Framework;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using MillionAndUp.Api.Helpers;

namespace MillionAndUp.Test
{
    public class UserTests
    {
        private readonly TestHostFixture _testHostFixture = new TestHostFixture();
        private HttpClient _httpClient;
        private IServiceProvider _serviceProvider;
        private MillionUpDbContext _millionUpDbContext;

        [SetUp]
        public void Setup()
        {
            _httpClient = _testHostFixture.Client;
            _serviceProvider = _testHostFixture.ServiceProvider;
            var options = new DbContextOptionsBuilder<MillionUpDbContext>()
                .UseSqlite(@"Data Source=MillionUpDb.db").Options;
            _millionUpDbContext = new MillionUpDbContext(options);
            _millionUpDbContext.Database.EnsureCreated();
        }

        [Test]
        public async Task ShouldExpect401WhenNotLoggedIn()
        {
            var response = await _httpClient.GetAsync("Users");
            Assert.AreEqual(HttpStatusCode.Unauthorized, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            Assert.That(result, Is.Empty);
        }

        [Test]
        public async Task ShouldExpect200WhenLoggedIn()
        {
            var testUser = await _millionUpDbContext.Users.OrderBy(x=>x.UserId).LastAsync();
            var credentials = new AuthenticateRequest
            {
                Username = testUser.Username,
                Password = testUser.Password
            };

            var authenticatedUser = await MakeLoginRequest(credentials);
            Assert.That(authenticatedUser, Is.InstanceOf(typeof(AuthenticateResponse)));
            Assert.That(authenticatedUser.Token, Is.Not.Empty);
        }

        [Test]
        public async Task ShouldGetAuthenticatedUserUsingSuccessLogin()
        {
            var testUser = await _millionUpDbContext.Users.FirstAsync();
            var credentials = new AuthenticateRequest
            {
                Username = testUser.Username,
                Password = testUser.Password
            };

            var loginResult = await MakeLoginRequest(credentials);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(JwtBearerDefaults.AuthenticationScheme, loginResult.Token);
            var response = await _httpClient.GetAsync("Users/user");
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            var authenticatedUser = JsonSerializer.Deserialize<AuthenticateResponse>(result);
            Assert.AreEqual(testUser.Username, authenticatedUser.Username);
        }
        [Test]
        public async Task ShouldReturn401ForInvalidToken()
        {
            const string invalidTokenString =
                @"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYW8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJBZG1pbiIsImV4cCI6MTU5NDg1NzYxNSwiaXNzIjoiaHR0cHM6Ly9teXdlYmFwaS5jb20iLCJhdWQiOiJNeSBXZWJBcGkgVXNlcnMifQ.kjO-4siQxx3JVPVtV_jbmSP5fLp-SIJL92Zq3-weCIg";

            var jwtAuthManager = _serviceProvider.GetRequiredService<IJwtAuthManager>();
            Assert.Throws<SecurityTokenSignatureKeyNotFoundException>(() => jwtAuthManager.DecodeJwtToken(invalidTokenString));

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(JwtBearerDefaults.AuthenticationScheme, invalidTokenString);
            var response = await _httpClient.GetAsync("Users/user");
            Assert.AreEqual(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        private async Task<AuthenticateResponse> MakeLoginRequest(AuthenticateRequest request)
        {
            var loginResponse = await _httpClient.PostAsync("Users/authenticate",
                new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, MediaTypeNames.Application.Json));
            var loginResponseContent = await loginResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<AuthenticateResponse>(loginResponseContent);
        }

    }
}