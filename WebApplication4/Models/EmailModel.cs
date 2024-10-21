using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class EmailModel
    {
        public String From { get; set; }
        public String To { get; set; }
        public String Subject { get; set; }
        public String Notes { get; set; }
    }
}