using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using FluentNHibernate.Testing.Values;
using FluentNHibernate.Visitors;
using NHibernate;

namespace DataLayer.Data
{
    public class UnitDataInterrop
    {
        
        //заполняет справочник (коллекцию) единиц измерения  из БД и возвращает его
        public ObservableCollection<Unit> GetUnits()
        {
           ObservableCollection<Unit> unitList;

            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var tmpList = session.QueryOver<Unit>().List();
                 
                    transaction.Commit();

                    unitList = new ObservableCollection<Unit>();

                    foreach (Unit un  in tmpList)
                    {
                        unitList.Add(un);
                    }
                }
            }

            return unitList;
        }

        //обновляет данные единицы измерния
        public void UpdateUnit(Unit unit)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction =session.BeginTransaction())
                {
                        session.Update(unit);
                        transaction.Commit();
                }
            }
        }

        public int AddUnit(Unit unit)
        {
            int id;

            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    id=(int)session.Save(unit);

                    transaction.Commit();
                }
            }

            return id;

        }

        public void DeleteUnit(Unit unit)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(unit);
                    transaction.Commit();
                }
            }
        }
    }
}
