using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using msvHarmony.Api.Middleware;
using msvHarmony.Domain.Services;
using msvHarmony.Infrastructure.DataSource;
using msvHarmony.Infrastructure.Extensions;
using msvHarmony.Security;
using SixLabors.ImageSharp;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

builder.Services.AddValidatorsFromAssemblyContaining<Program>(ServiceLifetime.Singleton);

builder.Services.AddDbContext<HarmonyContext>(opts =>
{
    opts.UseSqlServer(config.GetConnectionString("db"));
});

builder.Services.AddDomainServices();
builder.Services.AddDomainSecurityServices();
builder.Services.ConfigureSecurityServices(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(Assembly.Load("msvHarmony.Application"), typeof(Program).Assembly);
builder.Services.AddMediatR(Assembly.Load("msvHarmony.Application"), typeof(Program).Assembly);
builder.Services.AddSingleton<AzureBlobService>();

string CORSOpenPolicy = "OpenCORSPolicy";
builder.Services.AddCors(options =>
{
    options.AddPolicy(
    name: CORSOpenPolicy,
    builder =>
    {
        builder.WithOrigins("*").AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseCors(CORSOpenPolicy);

app.UseMiddleware<AppExceptionHandlerMiddleware>();

//app.MapGroup("/api/voter").MapVoter().AddEndpointFilterFactory(ValidationFilter.ValidationFilterFactory);

app.MapControllers();
app.Run();
