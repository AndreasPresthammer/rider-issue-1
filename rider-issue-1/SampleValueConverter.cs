using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace rider_issue_1;

public class SampleValueConverter : ValueConverter<SampleValue, int>
{
    public SampleValueConverter()
    : base(x => 1, i => new SampleValue())
    {
    }
}
