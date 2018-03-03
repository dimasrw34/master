using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    //Единица измерения
    public class Unit 
    {
        public virtual int Id { get; set; } //ид единицы измерения
        public virtual string FullName { get; set; } //Полное наименование единицы измерения
        public virtual string ShortName { get; set; } //Сокращенное наименование единицы измерения
    }
}
