using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INPRESA
{
    class ModeloCorreo
    {
        MailMessage  correos= new MailMessage(); //PARA
        public void enviarCorreo(string destinatario, string ruta)
        {
            try
            {

                SmtpClient client = new SmtpClient();
                client.Port = 587;
                // utilizamos el servidor SMTP de gmail
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                client.Timeout = 100000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                // nos autenticamos con nuestra cuenta de gmail
                client.Credentials = new NetworkCredential("vehiculosinpresa@gmail.com", "inpresa2021");

                MailMessage mail = new MailMessage("vehiculosinpresa@gmail.com", destinatario, 
                    "Orden de Servicio Interiorismo y Prefabricados SA. de CV.",
                    "Gracias por visitarnos. Adjunto su Orden de Servicio. " 
                   + "Atte:" +
                    " INPRESA Vehículos");
                mail.BodyEncoding = UTF8Encoding.UTF8;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                System.Net.Mail.Attachment archivo = new System.Net.Mail.Attachment(ruta);
                correos.Attachments.Add(archivo);
                mail.Attachments.Add(archivo);
                client.Send(mail);
                MessageBox.Show("El mensaje fue enviado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se envió el correo correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EnviarCita(string destinatario, DateTime Fecha, DateTime Hora, string MotivoCita) 
        {
            string FechaHora = "Cita Agendada para " + Fecha.ToString("d") + " a las " + Hora.ToString("HH: mm:ss") + " Horas ";
            string Mot = "Con el motivo de " + MotivoCita;
            try
            {

                SmtpClient client = new SmtpClient();
                client.Port = 587;
                // utilizamos el servidor SMTP de gmail
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                // nos autenticamos con nuestra cuenta de gmail
                client.Credentials = new NetworkCredential("vehiculosinpresa@gmail.com", "inpresa2021");

                MailMessage mail = new MailMessage("vehiculosinpresa@gmail.com", destinatario, FechaHora, Mot);
                mail.BodyEncoding = UTF8Encoding.UTF8;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                client.Send(mail);
                MessageBox.Show("El mensaje fue enviado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se envió el correo correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
