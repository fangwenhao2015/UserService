using UserService.Data;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSqlServer<UserServiceContext>(builder.Configuration.GetConnectionString("DefaultConnection"));

var app = builder.Build();

app.MapGet("/", (UserServiceContext db) =>
{

    db.Database.EnsureCreated();
    return "Hello World!";

});

app.Run();
