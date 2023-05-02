using Microsoft.EntityFrameworkCore;
using PracticaCrudUsuarios.Data;
using PracticaCrudUsuarios.Repository;
using PracticaCrudUsuarios.Repository.IRepository;
using PracticaCrudUsuarios.UsuariosMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ApplicationDbContext>(opt =>{
	opt.UseSqlServer(builder.Configuration.GetConnectionString("database"));
});
// Add repository
builder.Services.AddScoped<IUserRepository, UserRepository>();

// Add AutoMapper
builder.Services.AddAutoMapper(typeof(UsersMapper));

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
