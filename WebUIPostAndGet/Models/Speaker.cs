using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUIPostAndGet.Models
{
    public class Speaker
    {
       
        public string Name { get; set; }

        public string Bio { get; set; }

        public virtual string WebSite { get; set; }
    }
}
