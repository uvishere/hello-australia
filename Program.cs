var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello Australia!");

app.MapGet("/states", () =>
{
    var states = new[]
    {
        "New South Wales",
        "Victoria",
        "Queensland",
        "Western Australia",
        "South Australia",
        "Tasmania",
        "Australian Capital Territory",
        "Northern Territory"
    };
    return Results.Json(states);
});

app.MapGet("/state-facts/{state}", (string state) =>
{
    var facts = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        { "New South Wales", "Sydney, the capital of New South Wales, is home to the world-famous Sydney Opera House." },
        { "Victoria", "Melbourne, Victoria's capital, is known as the coffee capital of the world." },
        { "Queensland", "Queensland is home to the Great Barrier Reef, the world's largest coral reef system." },
        { "Western Australia", "Western Australia is the largest state in Australia, covering about one-third of the continent." },
        { "South Australia", "South Australia is famous for its wine regions, especially the Barossa Valley." },
        { "Tasmania", "Tasmania is home to the famous Tasmanian Devil, a carnivorous marsupial found only on the island." },
        { "Australian Capital Territory", "The Australian Capital Territory contains Canberra, the capital city of Australia." },
        { "Northern Territory", "The Northern Territory is home to Uluru, one of Australia's most iconic natural landmarks." }
    };

    if (facts.TryGetValue(state, out var fact))
    {
        return Results.Json(new { state = facts.Keys.First(k => k.Equals(state, StringComparison.OrdinalIgnoreCase)), fact });
    }
    else
    {
        return Results.Json(new { error = "State not found. Please provide a valid Australian state or territory." }, statusCode: 404);
    }
});

app.Run();
