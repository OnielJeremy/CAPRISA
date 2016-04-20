﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.SqlServer;
using System.Data.Entity;
namespace CaprisaProject.DAL
{
    public class CaprisaConfiguration : DbConfiguration
    {
        public CaprisaConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());

        }
    }
}