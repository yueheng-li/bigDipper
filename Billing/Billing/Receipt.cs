using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing
{
    class Receipt
    {

        public Receipt(string receiptType, string receiptName, double receiptAmount)
        {
            this.receiptType = receiptType;
            this.receiptName = receiptName;
            this.receiptAmount = receiptAmount;
        }

        public string receiptType { set; get; }
        public string receiptName { set; get; }
        public double receiptAmount { set; get; }
    }
}
