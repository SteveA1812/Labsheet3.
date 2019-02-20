using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet3.E1
{
    class Expenses
    {
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public DateTime ClaimedDate { get; set; }
       

        public override string ToString()
        {
            return $"{Type} {Amount:C} on {ClaimedDate.ToShortDateString()} ";
        }


    }
}
