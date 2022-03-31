using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Enviar_Email.Models;
using System.Net.Mail;
using System.Net;

namespace Enviar_Email.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EnviarEmail()
        {
            string emailDestinatario = Request.Form["txtEmail"];
            SendMail(emailDestinatario);
            return View();
        }

        public bool SendMail(string email)
        {
            for (int i = 0; i < 1; i++)
            {
                try
                {
                    MailMessage _mailMessage = new MailMessage();

                    _mailMessage.From = new MailAddress(email);
                    _mailMessage.To.Add(email);
                    //_mailMessage.CC.Add("v.concuruto@gmail.com");
                    _mailMessage.Subject = "Teste Caio";
                    _mailMessage.IsBodyHtml = true;
                    _mailMessage.Body = "<b>Olá Teste de Email</b>";

                    //Configuração da porta de email cada email tem um codigo
                    SmtpClient _smtpClient = new SmtpClient("smtp.gmail.com", Convert.ToInt32("587"));

                    //Configuração sem porta
                    //SmtpClient _smtpClient = new SmtpClient(UtilRsource.ConfigSmtp);

                    //Credencial para envio por SMTP Seguro (Quando o servidor exige autenticação)
                    _smtpClient.UseDefaultCredentials = false;

                    _smtpClient.Credentials = new NetworkCredential("kyle.vinnic@gmail.com", "//Vinnic.10");

                    _smtpClient.EnableSsl = true;

                    _smtpClient.Send(_mailMessage);
                }

                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return true;
        }
    }
}
