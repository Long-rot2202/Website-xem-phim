using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MovieStreamingApp.Data;
using MovieStreamingApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Thêm các dịch vụ vào container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<MovieService>();
builder.Services.AddSingleton<UserService>();
builder.Services.AddSingleton<ReviewService>();

var app = builder.Build();

// Cấu hình pipeline xử lý HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
