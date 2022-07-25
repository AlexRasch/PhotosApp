using PhotosApp.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<DataService>();

// Added for remote http request
builder.Services.AddHttpClient();

//builder.Services.AddHttpClient("GitHub", httpClient =>
//{
//    httpClient.BaseAddress = new Uri("https://api.github.com/");
//
//    // using Microsoft.Net.Http.Headers;
//    // The GitHub API requires two headers.
//    httpClient.DefaultRequestHeaders.Add(
//        HeaderNames.Accept, "application/vnd.github.v3+json");
//    httpClient.DefaultRequestHeaders.Add(
//        HeaderNames.UserAgent, "HttpRequestsSample");
//});

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(x => x.MapControllers());
app.UseStaticFiles();
app.Run();
