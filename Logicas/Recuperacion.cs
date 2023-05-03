using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Logicas
{
    public class Recuperacion
    {
        public static bool recuperarContraseña(string correo)
        {
            //Usuario u = Usuario.BuscarContraseña(correo);

            if (true)
            {
                var fromAddress = new MailAddress("swideliveryapp@gmail.com", "Soporte SIVAA");
                var toAddress = new MailAddress(correo, "nombre");
                const string fromPassword = "hhikgvvjeyhbbnos";
                const string subject = "Recuperación de contraseña";
                string body = "Su contraseña es: ";//u.Contraseña + "";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }

                return true;
            }
            else
            {
                return false;
            }
            //u = null;
        }

        public static int validarCorreo(string correo)
        {
            if (correo != "")
            {
                if (Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    if (correo.Length <= 40)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 3;
            }
        }
    }
}
