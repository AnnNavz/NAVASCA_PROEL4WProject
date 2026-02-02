using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NAVASCA_PROEL4WProject.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<NAVASCA_PROEL4WProjectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("NAVASCA_PROEL4WProjectContext") ?? throw new InvalidOperationException("Connection string 'NAVASCA_PROEL4WProjectContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
