using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
using Try1.Hubs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR()
    .AddNewtonsoftJsonProtocol();


// 👉 Force the port to 5000
builder.WebHost.UseUrls("http://localhost:5050"); // or 5000


var app = builder.Build();
app.MapHub<ChatHub>("/chathub");
app.Run();
