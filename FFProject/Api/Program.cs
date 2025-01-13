using Application.Handlers.QueryHandlers.Users;
using Application.Mappers.ModelMappers;
using Infrastructure.Mappers;
using Infrastructure.Repositories;
using Infrastructure.Repositories.Interfaces;
using Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddControllers();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetUserQueryHandler).Assembly));
builder.Services.AddOpenApi();
builder.Services.AddSingleton<SupabaseClientService>();
builder.Services.AddScoped<UserEntityMapper>();
builder.Services.AddScoped<UserModelMapper>();
builder.Services.AddScoped<WeaponEntityMapper>();
builder.Services.AddScoped<WeaponModelMapper>();
builder.Services.AddScoped<GilsEntityMapper>();
builder.Services.AddScoped<GilsModelMapper>();
builder.Services.AddScoped<ShieldEntityMapper>();
builder.Services.AddScoped<ShieldModelMapper>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IWeaponRepository, WeaponRepository>();
builder.Services.AddScoped<IGilsRepository, GilsRepository>();
builder.Services.AddScoped<IShieldRepository, ShieldRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.UseRouting();
app.MapControllers();

app.Run();