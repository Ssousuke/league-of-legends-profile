using LOLProfile.API.ZED.HttpService;
using LOLProfile.API.ZED.RestService;
using LOLProfile.API.ZED.RestService.IRestService;
using LOLProfile.Infra.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddInfraestructure(builder.Configuration);
builder.Services.AddScoped<IRiotHttpService, RiotHttpService>();
builder.Services.AddScoped<ISummonerRestServices, SummonerRestServices>();
builder.Services.AddScoped<ILeagueRestServices, LeagueRestService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
