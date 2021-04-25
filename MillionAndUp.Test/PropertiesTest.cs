
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
using System.Collections.Generic;

namespace MillionAndUp.Test
{
    public class PropertiesTests
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
            var response = await _httpClient.GetAsync("Property");
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            var properties = JsonSerializer.Deserialize<List<Property>>(result);

            var testProperty = await _millionUpDbContext.Properties.FirstAsync();
            var foundProperty = properties.Single(x => x.PropertyId == testProperty.PropertyId);

            Assert.AreEqual(testProperty.Name, foundProperty.Name);
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
