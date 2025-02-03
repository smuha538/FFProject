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
builder.Services.AddScoped<ItemEntityMapper>();
builder.Services.AddScoped<ItemModelMapper>();
builder.Services.AddScoped<CharacterEntityMapper>();
builder.Services.AddScoped<CharacterModelMapper>();
builder.Services.AddScoped<EnemyEntityMapper>();
builder.Services.AddScoped<EnemyModelMapper>();
builder.Services.AddScoped<AccessoryEntityMapper>();
builder.Services.AddScoped<AccessoryModelMapper>();
builder.Services.AddScoped<TrackEntityMapper>();
builder.Services.AddScoped<TrackModelMapper>();
builder.Services.AddScoped<CharacterSpriteEntityMapper>();
builder.Services.AddScoped<CharacterSpriteModelMapper>();
builder.Services.AddScoped<ArmourEntityMapper>();
builder.Services.AddScoped<ArmourModelMapper>();
builder.Services.AddScoped<UserItemEntityMapper>();
builder.Services.AddScoped<UserItemModelMapper>();
builder.Services.AddScoped<UserTrackEntityMapper>();
builder.Services.AddScoped<UserTrackModelMapper>();
builder.Services.AddScoped<CharacterEquipmentEntityMapper>();
builder.Services.AddScoped<CharacterEquipmentModelMapper>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IWeaponRepository, WeaponRepository>();
builder.Services.AddScoped<IGilsRepository, GilsRepository>();
builder.Services.AddScoped<IShieldRepository, ShieldRepository>();
builder.Services.AddScoped<IItemRepository, ItemRepository>();
builder.Services.AddScoped<ICharacterRepository, CharacterRepository>();
builder.Services.AddScoped<IEnemyRepository, EnemyRepository>();
builder.Services.AddScoped<IAccessoryRepository, AccessoryRepository>();
builder.Services.AddScoped<ITrackRepository, TrackRepository>();
builder.Services.AddScoped<ICharacterSpriteRepository, CharacterSpriteRepository>();
builder.Services.AddScoped<IArmourRepository, ArmourRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.UseRouting();
app.MapControllers();

app.Run();