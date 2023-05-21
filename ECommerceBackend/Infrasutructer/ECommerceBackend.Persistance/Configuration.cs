using Microsoft.Extensions.Configuration;

using Microsoft.EntityFrameworkCore;

namespace ECommerceBackend.Persistance
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get {
                ConfigurationManager configurationManager = new ConfigurationManager();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ECommerceBackend.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("PostgreSQL");
            }
        }
    }
}
