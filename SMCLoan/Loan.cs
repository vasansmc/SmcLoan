using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCLoan
{


    public class Loan
    {
        public decimal Principal { get; set; }
        public decimal Outstanding { get; set; }
        public DateTime LastPayDate { get; set; }

        public Bank PreviousOwner { get; set; }
        public List<Payment> Payments { get; set; }

        public Loan() //ctor tab tab
        : this(0,0,null,new DateTime()){
            //
        }
        public Loan(decimal principal, decimal outstanding, Bank previousOwner, DateTime lastPayDate)
        {
            this.Principal = principal;
            this.Outstanding = outstanding;
            this.PreviousOwner = previousOwner;
            this.LastPayDate = lastPayDate;

            Payments = new List<Payment>();
        }

        public Payment Pay(DateTime date, decimal amount)
        {
            var payment = new Payment();
            TimeSpan ts = date - LastPayDate;
            int days = ts.Days;
            decimal interestAmount = Math.Round(this.Outstanding * (decimal)PreviousOwner.InterestRate
                                      * days / 36500,
                                      2, MidpointRounding.AwayFromZero);

            interestAmount += this.Accrued;

            payment.Days = days;
            payment.PaidAmount = amount;
            payment.PaidDate = date;

            if (interestAmount <= amount)
            {
                payment.InterestAmount = interestAmount;
                this.Accrued = 0m;
            }
            else
            {
                payment.InterestAmount = amount;
                this.Accrued = interestAmount - amount;
            }

            payment.PaidPrincipalAmount = amount - payment.InterestAmount;
            payment.Outstanding = this.Outstanding - payment.PaidPrincipalAmount;

            this.LastPayDate = date;
            this.Outstanding = payment.Outstanding;

            this.Payments.Add(payment);

            return payment;
            //throw new NotImplementedException();
        }

        public Decimal Accrued { get; set; }
    }
}
