using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;

namespace HelloDotnet.Tests;

public class EndpointTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public EndpointTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task RootReturnsGreeting()
    {
        var response = await _client.GetAsync("/");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.Equal("Hello from .NET", await response.Content.ReadAsStringAsync());
    }

    [Fact]
    public async Task HealthReturnsUp()
    {
        var response = await _client.GetAsync("/health");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.Equal("UP", await response.Content.ReadAsStringAsync());
    }
}
