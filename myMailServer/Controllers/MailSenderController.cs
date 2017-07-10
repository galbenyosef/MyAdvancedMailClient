using myMailLibrary;
using MyMailServer;
using System.Web.Http;

namespace myMailServer.Controllers
{
    public class MailSenderController : ApiController
    {
        // POST: api/MailSender
        public IHttpActionResult Post([FromBody]Message message)
        {
            //if (message == null)
            //    return NotFound();
            EmailClient service = new EmailClient("csharpdevs@gmail.com", "123456---");
            foreach (var recipient in message.Contacts)
                service.Send(recipient.MailAddress, message.Subject, message.Body);
            return Ok();
        }

    }
}
