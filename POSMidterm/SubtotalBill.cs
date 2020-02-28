using System;
using System.Collections.Generic;

namespace POSMidterm



{
    public static class SubtotalBill
    {

        public static double GetTotal(double price, double qty)
        {
            double subtotal = price * qty;
            return subtotal;
        }

        public static double GetActualTotal(double price, double qty)
        {
            double actualTotal = GetTotal(price, qty) * 1.06;
            return actualTotal;
        }

        public static double GetChange(double amountTendered, double actualTotal)
        {
            double changeTotal = amountTendered - actualTotal;
            return changeTotal;
        }


    }

}

   