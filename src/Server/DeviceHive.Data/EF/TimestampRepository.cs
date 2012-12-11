﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DeviceHive.Data.Model;
using DeviceHive.Data.Repositories;

namespace DeviceHive.Data.EF
{
    public class TimestampRepository : ITimestampRepository
    {
        public DateTime GetCurrentTimestamp()
        {
            using (var context = new DeviceHiveContext())
            {
                return context.Database.SqlQuery<DateTime>("select sysutcdatetime()").First();
            }
        }
    }
}
