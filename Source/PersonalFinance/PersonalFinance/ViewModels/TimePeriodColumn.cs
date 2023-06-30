using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance.ViewModels
{
    public class TimePeriodColumn
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public List<TimePeriodAccount> Accounts { get; set; }
    }

    public class TimePeriodAccount
    {
        public int AccountId { get; set; }
        public List<BudgetCell> InBudgetCells { get; set; }
        public List<BudgetCell> OutBudgetCells { get; set; }
        public decimal AccountBalance { get; set; }
    }
}
