using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    //Подразделение (истина - подразделение, ложь - должность)
    class Department
    {
        public virtual int Id { get; set; }
        public virtual int ParentId { get; set; }
        public virtual string Text { get; set; }
        public virtual string TextEmployee { get; set; }
        public virtual bool IsDepartment { get; set; } = true;
    }
}
