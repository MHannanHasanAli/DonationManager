using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Entities
{
    public class Balance
    {
        [Key]
        public int _id { get; set; }
        public decimal _CashBalance { get; set; }
        public decimal _BankBalance { get; set; }
        public decimal _TotalBalance
        {
            get
            {
                return this._CashBalance + this._BankBalance;
            }
        }
        public decimal _MoneyGoingIn { get; set; }
        public decimal _MoneyPaidOut { get; set; }
    }
}
