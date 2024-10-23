using KafkaSpy.Api.Controllers;
using KafkaSpy.Web.Components;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddMvc().AddApplicationPart(typeof(ClustersController).Assembly);

builder.Services
    .AddControllers();

builder.Services
    .AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app
    .MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
