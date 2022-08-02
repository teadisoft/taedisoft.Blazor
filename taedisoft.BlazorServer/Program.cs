using DevExpress.Entity.Model;
using Microsoft.Net.Http.Headers;
using System.Net.Http.Headers;
using taedisoft.BlazorServer.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDevExpressBlazor();

builder.Services.AddScoped<WeatherForecastService>();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddHttpClient("_Host", c => c.BaseAddress = new Uri("http://localhost:5001"));
//builder.Services.AddHttpClient("_Host", c => c.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);

//builder.Services.AddScoped(sp =>
//    new HttpClient
//    {
//        BaseAddress = new Uri("https://localhost:5001")
//    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
