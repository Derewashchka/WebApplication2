var builder = WebApplication.CreateBuilder(args);

// Додайте SignalR до контейнера служб
builder.Services.AddSignalR();

var app = builder.Build();

// Налаштуйте маршрутизацію для SignalR
app.MapHub<ll1.Hubs.ChatHub>("/chatHub");

// Додайте маршрут для статичних файлів (HTML, JS тощо)
app.UseDefaultFiles();
app.UseStaticFiles();

app.Run();