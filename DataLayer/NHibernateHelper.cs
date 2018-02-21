using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace DataLayer
{
    public class NHibernateHelper
    {
        public NHibernateHelper()
        {
            InitializeSeccionFactory();
        }

        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {

                if (_sessionFactory == null)
                {
                    InitializeSeccionFactory();
                }

                return _sessionFactory;
            }
        }

        private static void InitializeSeccionFactory()
        {
        
            _sessionFactory = Fluently.Configure().Database(
                    MsSqlConfiguration.MsSql2012.ConnectionString(
                        cs => cs.Server("DEVCOMP")
                            .Database("DEVBASE")
                            .TrustedConnection()).ShowSql
                ).Mappings(m => m.FluentMappings.AddFromAssemblyOf<NHibernateHelper>())
                .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, false))
                .BuildSessionFactory();
         
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
