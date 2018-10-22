using System;
using System.Net;
using System.Net.Mail;

class EmailSmtp {
  static void Main(string[] args) {
    try {
      var credentials = new NetworkCredential("huang.degil@gmail.com", "(ghkd9521)");
      var mail = new MailMessage() {
        From = new MailAddress("huang.degil@gmail.com"),
        Subject = "Test email.",
        Body = "Test email body"
      };
      mail.To.Add(new MailAddress("huang_@naver.com"));
      var client = new SmtpClient() {
        Port = 587,
        DeliveryMethod = SmtpDeliveryMethod.Network,
        UseDefaultCredentials = false,
        Host = "smtp.gmail.com",
        EnableSsl = true,
        Credentials = credentials
      };
      client.Send(mail);
    } catch (Exception ex) {
      Console.WriteLine("Error in sending email: " + ex.Message);
      Console.ReadKey();
      return;
    }
    Console.WriteLine("Email sccessfully sent");
    Console.ReadKey();
  }
}