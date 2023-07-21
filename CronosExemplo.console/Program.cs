using CronosExemplo.console.Core.Extensions;
using CronosExemplo.console.Core.TimerSchedulers;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.AddSerilog();

builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Ativação das Crons
builder.Services.AddCronJob<DisparoDeTriggers>(c => c.CronExpression = @"0 */1 * * * *");
builder.Services.AddCronJob<VerificaAlgumaCoisa>(c => c.CronExpression = @"5 * * * * *");

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();