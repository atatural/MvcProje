using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        [StringLength(100)]
        public string ContactName { get; set; }
        [StringLength(100)]
        public string ContactMail { get; set; }
        [StringLength(100)]
        public string ContactSubject { get; set; }
        [StringLength(1000)]
        public string ContactMessage { get; set; }
    }
}
