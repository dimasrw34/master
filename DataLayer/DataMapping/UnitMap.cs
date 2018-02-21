using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using FluentNHibernate.Mapping;

namespace DataLayer.DataMapping
{
    class UnitMap:ClassMap<Unit>
    {
        public UnitMap()
        {
            Id(x => x.Id).Column("UnitsID");
            Map(x => x.FullName).Column("UnitsName");
            Map(x => x.ShortName).Column("SUnitsName");
            Table("dicUnits");
        }
    }
}
