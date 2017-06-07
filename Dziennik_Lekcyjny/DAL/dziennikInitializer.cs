using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Dziennik_Lekcyjny.DAL
{
    public class dziennikInitializer : DropCreateDatabaseIfModelChanges<dziennikContext>
    {
        protected override void Seed(dziennikContext context)
        {
            base.Seed(context);
        }

    
    }
}