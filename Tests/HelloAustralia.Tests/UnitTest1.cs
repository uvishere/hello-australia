using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace HelloAustralia.Tests;

public class StatesApiTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public StatesApiTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task GetStates_ReturnsAllStates()
    {
        var client = _factory.CreateClient();
        var response = await client.GetAsync("/states");
        response.EnsureSuccessStatusCode();
        var states = await response.Content.ReadFromJsonAsync<string[]>();
        Assert.NotNull(states);
        Assert.Contains("New South Wales", states);
        Assert.Contains("Victoria", states);
        Assert.Contains("Queensland", states);
        Assert.Contains("Western Australia", states);
        Assert.Contains("South Australia", states);
        Assert.Contains("Tasmania", states);
        Assert.Contains("Australian Capital Territory", states);
        Assert.Contains("Northern Territory", states);
        Assert.Equal(8, states.Length);
    }
}
