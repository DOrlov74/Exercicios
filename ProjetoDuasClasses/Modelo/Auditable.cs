using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Auditable
    {
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
