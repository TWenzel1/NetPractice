using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Models
{
    public class FutureValueModel
    {  
        [Required(ErrorMessage = "Please enter a monthly investment amount.")]
        [Range (1,500, ErrorMessage ="Monthly investment amount must be between 1 and 500.")]

        public decimal MonthlyInvestment { get; set; }
        [Required(ErrorMessage = "Please enter a monthly investment amount.")]
        public decimal YearlyInterestRate { get; set; }
        [Required]
        public int Years { get; set; }

        public  decimal? CalculateFutureValue()
        {
            int months = Years * 12;
            decimal monthlyInterestRate = YearlyInterestRate / 12 / 100;
            decimal futureValue = 0;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;





        }


    }
}
