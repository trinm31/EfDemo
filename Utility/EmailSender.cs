using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace EntityFramworkDemo.Utility
{
    public class EmailSender: IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            throw new System.NotImplementedException();
        }
    }
}