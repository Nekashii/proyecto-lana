using Microsoft.EntityFrameworkCore;
using Store;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionStrig = "Server=DESKTOP-NQJ0HTO\\SQLEXPRESS;Database=Proyecto;Uid=root;Pwd=root";
builder.Services.AddDbContext<ApplicationDbContext>(opt =>
{
    opt.UseSqlServer(connectionStrig);
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure CORS
app.UseCors(policyBuilder => policyBuilder
    .AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod()
);


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();