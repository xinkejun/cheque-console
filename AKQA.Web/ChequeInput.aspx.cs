using System;
using System.Text;

namespace AKQA.Web
{
    public partial class ChequeInput : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_ServerClick(object sender, EventArgs e)
        {
            var sb = new StringBuilder("<ul>");
            var errCount = 0;

            if (string.IsNullOrWhiteSpace(nameInput.Value))
            {
                sb.Append("<li>Name is required</li>");
                errCount++;
            }

            if (string.IsNullOrWhiteSpace(amountInput.Value))
            {
                sb.Append("<li>Amount is required</li>");
                errCount++;
            }
            else
            {
                double amount = -1;
                if (double.TryParse(amountInput.Value, out amount))
                {
                    if (amount < 0)
                    {
                        sb.Append("<li>Amount should be positive</li>");
                        errCount++;
                    }
                }
                else
                {
                    sb.Append("<li>Wrong amount format</li>");
                    errCount++;
                }
            }
            sb.Append("</ul>");

            if (errCount > 0)
            {
                divAlert.InnerHtml = sb.ToString();
                divAlert.Attributes["class"] = "alert alert-danger";
            }
            else
            {
                sb.Clear();
                sb.Append("<ul>");
                sb.Append("<li>Name: ").Append(nameInput.Value).Append("</li>");
                var amountText = new ChequeService().GetChequeAmountText(double.Parse(amountInput.Value));
                sb.Append("<li>Amout: ").Append(amountText).Append("</li>");
                sb.Append("</ul>");
                divAlert.InnerHtml = sb.ToString();
                divAlert.Attributes["class"] = "alert alert-info";
            }

        }

    }
}