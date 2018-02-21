using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Unit
    {
        public virtual int Id { get; set; }
        public virtual string FullName { get; set; }
        public virtual string ShortName { get; set; }
    }
}
