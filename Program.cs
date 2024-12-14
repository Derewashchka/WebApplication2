var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();

var app = builder.Build();

app.MapHub<ll1.Hubs.ChatHub>("/chatHub");

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/user1", async context => {
    context.Response.ContentType = "text/html";
    await context.Response.SendFileAsync("wwwroot/user1.html");
});

app.MapGet("/user2", async context => {
    context.Response.ContentType = "text/html";
    await context.Response.SendFileAsync("wwwroot/user2.html");
});

app.Run();