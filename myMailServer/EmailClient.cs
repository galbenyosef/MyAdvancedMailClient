using System;
using System.Collections.Generic;

using System.Net.Http;

namespace MyMailServer
{ 
    /// <summary>
    /// Send emails using httpmail service.
    /// </summary>
    public class EmailClient
    {
        private readonly HttpClient client;
        private readonly string gmailAccount;
        private readonly string password;
        private const string ServiceUrl = "https://httpmail.azurewebsites.net";

        /// <summary>
        /// Create a new <see cref="EmailClient"/>.
        /// </summary>
        /// <param name="gmailAccount">The email account to use. 
        /// Must be a gmail account. 
        /// The account must be configured to allow less secure apps.</param>
        /// <param name="password">The gmail account's password</param>
        public EmailClient(string gmailAccount, string password)
        {
            client = new HttpClient { BaseAddress = new Uri(ServiceUrl) };
            this.gmailAccount = gmailAccount;
            this.password = password;
        }

        /// <summary>
        /// Send a message using the configured account.
        /// </summary>
        /// <param name="to">The email to send the message to.</param>
        /// <param name="subject">The subject of the messsage</param>
        /// <param name="body">The body of the message</param>
        public void Send(string to, string subject, string body)
        {
            var fields = CreateBody(to, subject, body);
            var content = new FormUrlEncodedContent(fields);
            client.PostAsync("/api/Message", content).Wait();
        }

        private IEnumerable<KeyValuePair<string, string>> CreateBody(string to, string subject, string body)
        {
            return new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("to", to),
                new KeyValuePair<string, string>("subject", subject),
                new KeyValuePair<string, string>("body", body),
                new KeyValuePair<string, string>("account", gmailAccount),
                new KeyValuePair<string, string>("password", password)
            };
        }
    }
}
