using Microsoft.EntityFrameworkCore;

namespace rider_issue_1;

public class SampleService
{
    private readonly DatabaseContext _databaseContext;

    public SampleService(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
    }

    public async Task<SampleValue> Repro()
    {
        var result = await _databaseContext.SamplesEntities
            .FirstOrDefaultAsync();

        return result.SampleValue;
    }
}