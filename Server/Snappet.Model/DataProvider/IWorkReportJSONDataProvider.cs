﻿using Snappet.Model.Domain;
using Snappet.Model.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snappet.Model.DataProvider
{
   public interface IWorkReportJSONDataProvider
    {
        IEnumerable<FilterDateSubject> GetFilterDetails();
        IEnumerable<FilterDateSubject> GetFilterDetailsByDate(string dateTime);
        IEnumerable<WorkReport> GetWorkReport(DateTime date, string subject, string domain);
    }
}
