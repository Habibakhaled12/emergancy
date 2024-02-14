using sign.core.rebosatory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sign.core.entity
{
    public class signup :baseEntity
    {
   
        public string name { get; set; }
        public string e_mail { get; set; }
        public int password { get; set; }
   
        public int phone_number { get; set; }
    }
}
