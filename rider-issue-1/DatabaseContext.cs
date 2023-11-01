using Microsoft.EntityFrameworkCore;

namespace rider_issue_1;

public class DatabaseContext : DbContext
{
    public DbSet<SampleEntity> SamplesEntities => Set<SampleEntity>();

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<SampleValue>().HaveConversion<SampleValueConverter>();
    }
}