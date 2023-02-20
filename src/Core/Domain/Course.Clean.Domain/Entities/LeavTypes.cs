using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Clean.Domain.Entities
{
    public class LeavTypes : AuditableBaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
