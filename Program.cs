using BlazorSpinner;
using ExamenInnovation;
using ExamenInnovation.RestApi;
using ExamenInnovation.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;
using Refit;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddTransient<IGloalService,GoalService>();
builder.Services.AddTransient<ITaskService,TaskService>();

builder.Services.AddRadzenComponents();
builder.Services.AddScoped<SpinnerService>();

builder.Services.AddRefitClient<IRestApi>().ConfigureHttpClient(c=>c.BaseAddress =  new Uri("https://localhost:7217"));

await builder.Build().RunAsync();
