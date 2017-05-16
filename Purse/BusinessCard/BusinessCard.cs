using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCard
{
    public class BusinessCard
    {
        public decimal amount = 0;
        private string msg = "Business Card balanse: ";

        public string GetSumCreditCard()
        {
            return msg + amount.ToString();
        }

        public BusinessCard(decimal amount)
        {
            this.amount = amount;
        }

    }
}
