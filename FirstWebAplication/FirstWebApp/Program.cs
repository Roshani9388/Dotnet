var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/aboutus",()=>"Hii from Roshani Patil");

app.Run();
