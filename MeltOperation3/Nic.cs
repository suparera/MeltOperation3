using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Text;

namespace MeltOperation3
{
    class Nic
    {
        private static NICDBEntities nicdbContext;
        public static NICDBEntities getNicdbContext()
        {
            if (nicdbContext == null)
            {
                nicdbContext = new NICDBEntities();
            }
            return nicdbContext;
        }
    }

}

