using System.Data;
using Dapper;

namespace Scan_Product_TTTQ.Infrastructure.Data
{
    public class TimeOnlyHandler : SqlMapper.TypeHandler<TimeOnly>
    {
        public override void SetValue(IDbDataParameter parameter, TimeOnly value)
        {
            parameter.Value = value.ToString("HH:mm");
        }

        public override TimeOnly Parse(object value)
        {
            return TimeOnly.Parse(value.ToString());
        }
    }
}