// Copyright (c) Creape. All Rights Reserved.



using MediatR;
using PSE.Application.AutoMapper;
using PSE.Application.DTOs;
using PSE.Application.Services.EventosService.Queries.ListEventosRequest;
using PSE.Client.Configurations;
using PSE.Infrastructure.CrossCutting;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: false, reloadOnChange: true);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddConsumerConfiguration(builder.Configuration);
builder.Services.AddDependencyInjectionConfiguration(builder.Configuration);

// Mediator
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddScoped<IRequestHandler<ListEventosRequest, List<EventosDTO>>, ListEventosRequestHandler>();

// Mapper
builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile<EventosProfile>();
});


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=index}/{id?}");

app.Run();
