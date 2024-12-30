using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLearn.Models.Models
{
    public abstract class BaseModel
    {
        public int ActionTaken { get; set; }
        public string ActionType { get; set; }
        public DateTime ActionDate { get; set; }
    }
}
