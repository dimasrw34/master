using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using FluentNHibernate.Testing.Values;
using FluentNHibernate.Visitors;

namespace DataLayer.Data
{
    public class UnitDataInterrop
    {

        public List<Unit> GetUnits()
        {
            List<Unit> unitList;

            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    unitList = (List < Unit > )session.QueryOver<Unit>().List();

                    transaction.Commit();
                }
            }

            return unitList;
        }


    }
}
