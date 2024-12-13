var builder = WebApplication.CreateBuilder(args);

// ������� SignalR �� ���������� �����
builder.Services.AddSignalR();

var app = builder.Build();

// ���������� ������������� ��� SignalR
app.MapHub<ll1.Hubs.ChatHub>("/chatHub");

// ������� ������� ��� ��������� ����� (HTML, JS ����)
app.UseDefaultFiles();
app.UseStaticFiles();

app.Run();