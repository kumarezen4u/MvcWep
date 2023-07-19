using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMvc.Areas.Employee.Models
{
    public class EMIDetails
    {
        public double EMICalculator(double principalAmount, double interestRate, int tenure)
        {

            double r = Math.Round((double)((double)interestRate / 12) / 100, 6);
            double E = principalAmount * (r * (Math.Pow(1 + r, tenure) / (Math.Pow(1 + r, tenure) - 1)));
            return Math.Round(E * tenure, 2);

        }


        public double PerMonthInterestrate(double principalAmount, double interestRate)
        {

            double rate = (double)((double)interestRate / 12) / 100;
            return (double)rate * principalAmount;
        }


        public List<EmiTable> GetEmiTable(double principalAmount, double interestRate, int tenure, DateTime emiDate)
        {
            List<EmiTable> emiTable = new List<EmiTable>();

            double totalAmount = EMICalculator(principalAmount, interestRate, tenure);

            double totalIntrest = Math.Round((double)totalAmount - principalAmount, 2);


            double monthlyRepaymentAmount = (double)totalAmount / tenure;

            int j = 1;

            for (int i = tenure; i > 0; i--)
            {

                double monthlyIntrest = PerMonthInterestrate(principalAmount, interestRate);

                EmiTable emi = new EmiTable();
                emi.PrincipalAmount = monthlyRepaymentAmount - monthlyIntrest;
                emi.InterestAmount = monthlyIntrest;
                emi.EmiDate = emiDate.AddMonths(j);
                emiTable.Add(emi);
                principalAmount = principalAmount - (double)(emi.PrincipalAmount);
                j++;

            }
            return emiTable;
        }
    }
    public class EmiTable
    {
        public double PrincipalAmount { get; set; }
        public double InterestAmount { get; set; }
        public DateTime EmiDate { get; set; }
       
    }

    public class EmiModel
    {
        public double PrincipalAmount { get; set; }
        public double InterestRate { get; set; } 
        public int tenure { get; set; }
        public DateTime EmiDate { get; set; }
        public List<EmiTable> EmiList { get; set; }

    }

}