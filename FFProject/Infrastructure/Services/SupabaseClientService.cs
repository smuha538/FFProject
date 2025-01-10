using Supabase;
using Microsoft.Extensions.Configuration;


namespace Infrastructure.Services;

public class SupabaseClientService(IConfiguration configuration)
{
    public Client Client { get; } = new(
        configuration["Supabase:Url"],
        configuration["Supabase:Key"],
        new SupabaseOptions
        {
            AutoRefreshToken = true,
            AutoConnectRealtime = true
        });
}