using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLearn.Models.Models
{
    public class Genre:BaseModel
    {
        public long GenreId { get; set; }
        public string GenreName { get; set; }
        public int DisplayOrder { get; set; }
    }
}
