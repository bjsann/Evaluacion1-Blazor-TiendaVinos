using Microsoft.EntityFrameworkCore;
using TiendaVinos.Server.DATA;
using TiendaVinos.Shared;

var builder = WebApplication.CreateBuilder(args);

#region Servicios
// 1. Configuramos los Controladores y Razor Pages (Apunte del profe)
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

// 2. Conectamos la Base de Datos con Entity Framework Core
builder.Services.AddDbContext<TiendaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionLocal")));
#endregion

var app = builder.Build();

#region Middleware
// 3. Configuraciones de entorno y seguridad (Apunte del profe)
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

// 4. Habilitamos los archivos de Blazor WebAssembly (Apunte del profe)
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

// 5. Mapeos finales (Apunte del profe)
app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");
#endregion

app.Run();