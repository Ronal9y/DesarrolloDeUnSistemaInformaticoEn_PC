using Microsoft.EntityFrameworkCore.Design;

namespace DesarrolloDeUnSistemaInformaticoEn_PC.Data
{
    public class ContextoFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("workstation id=Proyecto_AplicadoDb.mssql.somee.com;packet size=4096;user id=AHB_SQLLogin_1;pwd=lcv8kpbnpl;data source=Proyecto_AplicadoDb.mssql.somee.com;persist security info=False;initial catalog=Proyecto_AplicadoDb;TrustServerCertificate=True");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
