using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Portfolio
    {
        [Key]
        public int WorkID { get; set; }
        [StringLength(100)]
        public string WorkName { get; set; }
        [StringLength(1000)]
        public string WorkDescription { get; set; }
        [StringLength(100)]
        public string WorkImage { get; set; }
        [StringLength(100)]
        public string WorkBackgroundImage { get; set; }
        


    }
}
