using System.Text;
using MailKit.Net.Smtp;
using MimeKit;

namespace BankConsole;

public static class EmailService
{
    public static void SendMail()
    {
        #region MENSAJE
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress("Nelson Ysain Ortiz Leal", "nelsonortiz102@gmail.com"));
        message.To.Add(new MailboxAddress("Ysain", "ysainor@gmail.com"));
        message.Subject = "BankConsole: Usuarios nuevos";

        message.Body = new TextPart("plain")
        {
            Text = GetEmailText()
        };
        #endregion

        #region ENVIAR CORREO
        using (var client = new SmtpClient())
        {
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("nelsonortiz102@gmail.com", "skpnslzkhextelaa");
            client.Send(message);
            client.Disconnect(true);
        }
        #endregion
    }

    private static string GetEmailText()
    {
        List<User> newUsers = Storage.GetNewUser();

        if (newUsers.Count == 0)
        {
            return "No hay usuarios nuevos";
        }

        StringBuilder emailText = new StringBuilder("Usuarios agregados hoy:\n");

        foreach (User user in newUsers)
        {
            emailText.AppendLine("\t" + user.ShowData());
        }

        return emailText.ToString();
    }
}