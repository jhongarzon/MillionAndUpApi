
using System;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MillionAndUp.Api;
using MillionAndUp.Data;

namespace MillionAndUp.Test
{
    public class TestHostFixture : IDisposable
    {
        public HttpClient Client { get; }
        public IServiceProvider ServiceProvider { get; }

        public TestHostFixture()
        {
            var builder = Program.CreateHostBuilder(null)
                .ConfigureWebHost(webHost =>
                {
                    webHost.UseTestServer();
                    webHost.UseEnvironment("Test");
                });
            var host = builder.Start();
            ServiceProvider = host.Services;
            Client = host.GetTestClient();
            Console.WriteLine("TEST Host Started.");
        }

        public void Dispose()
        {
            Client.Dispose();
        }
    }
}
