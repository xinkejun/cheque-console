using System;
using System.Web.Http;

namespace AKQA.Web.Controllers
{
    [RoutePrefix("api/cheque")]
    public class ChequeController : ApiController
    {
        [HttpGet]
        [Route("getchequeamounttext/{amount}")]
        public string GetChequeAmountText(double amount)
        {
            if (amount == 0)
                return "ZERO";
            if (amount >= Math.Pow(10, 12))
                return "AMOUT TOO MUCH TO DISPLAY";

            var dollarNumber = Math.Floor(amount);
            var dollarText = this.ConvertNumberToWords(dollarNumber);
            var dollarUnit = dollarNumber == 1 ? "DOLLAR" : "DOLLORS";

            var centNumber = Math.Round(amount * 100) % 100;
            var centText = this.ConvertNumberToWords(centNumber);
            var centUnit = centNumber == 1 ? "CENT" : "CENTS";

            if (dollarNumber == 0 && centNumber != 0)
                return centText + centUnit;

            if (dollarNumber != 0 && centNumber == 0)
                return dollarText + dollarUnit;

            return dollarText + dollarUnit + " AND " + centText + centUnit;
        }

        private string ConvertNumberToWords(double amount)
        {
            if (amount == 0)
                return "ZERO";

            var words = string.Empty;
            if (Math.Floor(amount / Math.Pow(10, 9)) > 0)
            {
                words += this.ConvertNumberToWords(Math.Floor(amount / Math.Pow(10, 9))) + "BILLION ";
                amount %= Math.Pow(10, 9);
            }
            if (Math.Floor(amount / Math.Pow(10, 6)) > 0)
            {
                words += this.ConvertNumberToWords(Math.Floor(amount / Math.Pow(10, 6))) + "MILLION ";
                amount %= Math.Pow(10, 6);
            }
            if (Math.Floor(amount / 1000) > 0)
            {
                words += this.ConvertNumberToWords(Math.Floor(amount / 1000)) + "THOUSAND ";
                amount %= 1000;
            }
            if (Math.Floor(amount / 100) > 0)
            {
                words += this.ConvertNumberToWords(Math.Floor(amount / 100)) + "HUNDRED ";
                amount %= 100;
            }

            if (amount > 0)
            {
                var unitsMap = new string[]
                {
                    "ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN", "ELEVEN", "TWELVE", "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINETEEN"
                };
                var tensMap = new string[]
                {
                    "ZERO", "TEN", "TWENTY", "THIRTY", "FORTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINETY"
                };
                if (amount < 20)
                {
                    words += unitsMap[(int)amount] + " ";
                }
                else
                {
                    words += tensMap[(int)Math.Floor(amount / 10)];
                    if ((amount % 10) > 0) words += "-" + unitsMap[(int)amount % 10] + " ";
                }
            }
            return words;
        }

    }
}
