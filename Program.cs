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

app.Run();
