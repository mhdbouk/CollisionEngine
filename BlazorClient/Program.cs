using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorClient;
using Collider;
using Collider.Specifications;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<ICollisionSpecification, RectangleToRectangleCollisionSpecification>();
builder.Services.AddScoped<ICollisionSpecification, CircleToCircleCollisionSpecification>();
builder.Services.AddScoped<ICollisionSpecification, CircleToRectangleCollisionSpecification>();
builder.Services.AddScoped<CollisionEngine>();

await builder.Build().RunAsync();
