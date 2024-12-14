var builder = WebApplication.CreateBuilder(args);

// Додайте SignalR до контейнера служб
builder.Services.AddSignalR();

var app = builder.Build();

// Налаштуйте маршрутизацію для SignalR
app.MapHub<ll1.Hubs.ChatHub>("/chatHub");

// Додайте маршрут для статичних файлів (HTML, JS тощо)
app.UseDefaultFiles();
app.UseStaticFiles();

// Налаштуйте маршрути для різних користувачів
app.MapGet("/user1", async context => {
    context.Response.ContentType = "text/html";
    await context.Response.SendFileAsync("wwwroot/user1.html");
});

app.MapGet("/user2", async context => {
    context.Response.ContentType = "text/html";
    await context.Response.SendFileAsync("wwwroot/user2.html");
});

app.Run();