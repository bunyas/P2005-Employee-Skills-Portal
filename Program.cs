using Microsoft.EntityFrameworkCore;
using P2005_Employee_Skills_Portal.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connection = String.Empty;
if (builder.Environment.IsDevelopment())
{
    builder.Configuration.AddEnvironmentVariables().AddJsonFile("appsettings.Development.json");
    connection = builder.Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING");
}
else
{
    connection = Environment.GetEnvironmentVariable("AZURE_SQL_CONNECTIONSTRING");
}

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connection));

var app = builder.Build();

//Syncfusion.Licensing
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTYyODExQDMxMzkyZTMzMmUzMEhrNmVLOE84dlJ5d3RHdTVXNTJjdVdNdWZnTitJVTg3ejVvclBlTy9oMVk9;NTYyODEyQDMxMzkyZTMzMmUzMG1tY1hBZWJRK3hRT21kdjZid1pDZVFVVGJ1SEdpb0NGYjB2N1dvaE1iVUE9;NTYyODEzQDMxMzkyZTMzMmUzMFVtdEprZnhqcmJuN2U2YXU1a0sweHdtRXBMRTZVcm9EMy9RMHVCdGZMdG89;NTYyODE0QDMxMzkyZTMzMmUzMGtzTUtDWXpTMlBvYmxBc2FXMnVPR2diT1F6aU5KT0FteldqaVk4cHJYMUk9;NTYyODE1QDMxMzkyZTMzMmUzMGFpWWNEZHZLMytIK0xRZmgvblBNd2pzdTVGZ0tXbU5paUMyQVhxemFJblE9;NTYyODE2QDMxMzkyZTMzMmUzMGpJZmV1RnhDUDU5MEFtQ1hrQytJN3QrTTNUSklST1A5b3p2cTRGVnBvZmM9;NTYyODE3QDMxMzkyZTMzMmUzMGJNRjE0YWpubXhQMlYrVmlIeFVBUUZwcnVoNWdZbEpDVjljUTR1eGVWUjg9;NTYyODE4QDMxMzkyZTMzMmUzMFExK1NWT3FFOE8xT3ZLbHdxUUpFd3pQeVN5cTkrUkptd3NQTjRUdVFicG89;NTYyODE5QDMxMzkyZTMzMmUzMFJnUkRKajNaRnVZYTllVlNwRVZqL1gvektOK0ZYTnBZZDZCZnd4d0xxbUE9;NTYyODIwQDMxMzkyZTMzMmUzMEwvZllVVnQ4UjZMNGI5RzJJdmdmZ1hoK01wVEo4bitqT2RveFRHTkZVemc9;NTYyODIxQDMxMzkyZTMzMmUzMFUzY3o0QWpQazhxdnhZWU8vN3NVL2llZE9Mem5IMDlGNlprWVdqeHNSS1k9");

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
    pattern: "{controller=Staff}/{action=Staff}/{id?}");

app.Run();

public partial class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                //webBuilder.UseStartup<Startup>();
            });
}
