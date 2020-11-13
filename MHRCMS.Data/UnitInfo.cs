using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRCMS.Data
{
    public class UnitInfo
    {
        public int Id { get; set; }
        public int PersonnelId { get; set; }
        public int PlatoonId { get; set; }
        public int SquadId { get; set; }
        public int TeamId { get; set; }
        public string Role { get; set; }
        public DateTimeOffset Arrived { get; set; }
        public string DutyStatus { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid ModifiedLast { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
