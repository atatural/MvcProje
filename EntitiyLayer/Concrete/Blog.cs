using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        [StringLength(100)]
        public string BlogName { get; set; }
        [StringLength(3000)]
        public string BlogValue { get; set; }

        public DateTime BlogDate { get; set; }

    }
}
