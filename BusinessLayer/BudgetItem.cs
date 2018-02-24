using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    //Статья бюджета
    class BudgetItem
    {
        public virtual int Id { get; set; }
        public virtual int ParentID { get; set; }
        public virtual string OpenId { get; set; }
        public virtual string Text { get; set; }
        //добавить ссылку на объект Центр Финансовой Ответственности
    }
}
