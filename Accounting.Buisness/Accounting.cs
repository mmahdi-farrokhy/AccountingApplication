using Accounting.DataLayer.Context;
using Accounting.ViewModels.Accounting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AccoutingModel = Accounting.DataLayer.Context.Accounting;

namespace Accounting.Buisness
{
    public class Accounting
    {
        public static MonthlyReportViewModel MainFormReport()
        {
            MonthlyReportViewModel monthlyReport = new MonthlyReportViewModel();
            using (DBAccess db = new DBAccess())
            {
                DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
                int numOfMonthDays = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                DateTime endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, numOfMonthDays);

                Expression<Func<AccoutingModel, bool>>  incomeFilter = a => a.TypeID == 1 && a.DateTime >= startDate && a.DateTime <= endDate;
                Expression<Func<AccoutingModel, bool>> outcomeFilter = a => a.TypeID == 2 && a.DateTime >= startDate && a.DateTime <= endDate;
                var income = db.AccountingRepository.GetAll(incomeFilter).Select(a => a.Amount).ToList();
                var outcome = db.AccountingRepository.GetAll(outcomeFilter).Select(a => a.Amount).ToList();

                monthlyReport.Income = income.Sum();
                monthlyReport.Outcome = outcome.Sum();
                monthlyReport.AccountBalance = monthlyReport.Income - monthlyReport.Outcome;
            }

            return monthlyReport;
        }
    }
}
