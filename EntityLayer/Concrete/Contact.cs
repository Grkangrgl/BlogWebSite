using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContectId { get; set; }
        public string ContectUserName { get; set; }
        public string ContectMail { get; set; }
        public string ContectSubject { get; set; }
        public string ContectMessage { get; set; }
        public DateTime ContectDate { get; set; }
        public bool ContectStatus { get; set; }
    }
}
