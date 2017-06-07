using Dziennik_Lekcyjny.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Dziennik_Lekcyjny.DAL
{
    public class dziennikInitializer : MigrateDatabaseToLatestVersion<dziennikContext, Configuration>
    {
            
    }
}