using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLearn.Models.Models
{
    public class Movie : BaseModel
    {
        public long MovieId { get; set; } // just Id or entity name end with Id implicitly taken as primary key by EF Core
        public string MovieName { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
    }
}
