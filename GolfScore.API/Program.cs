using GolfScore.Repositories;
using GolfScore.Repositories.Interfaces;
using GolfScore.Services;
using GolfScore.Services.Interfaces;
using Microsoft.Azure.Cosmos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient();

string cosmosDbConnection = builder.Configuration["CosmosDBConnection"];
builder.Services.AddSingleton<CosmosClient>(serviceProvider =>
{
    IHttpClientFactory httpClientFactory = serviceProvider.GetRequiredService<IHttpClientFactory>();

    CosmosClientOptions cosmosClientOptions = new CosmosClientOptions
    {
        HttpClientFactory = httpClientFactory.CreateClient,
        ConnectionMode = ConnectionMode.Gateway
    };

    return new CosmosClient(cosmosDbConnection, cosmosClientOptions);
});

builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped<IPlayerService, PlayerService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
