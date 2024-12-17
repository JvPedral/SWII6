// João Vitor Pedral CB3022391
// Rodrigo Braga CB3018105

using Web.Utils.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var baseUrlApi = builder.Configuration["ApiUrl:ApiProjectUrl"];

builder.Services.AddTransient<ApiService>(s => new ApiService(new HttpClient(), baseUrlApi));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Project}/{action=Index}/{id?}");

app.Run();
