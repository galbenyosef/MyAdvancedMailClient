using System;
using System.Collections.Generic;

using System.Data.Entity;

namespace myMailLibrary
{
    public class myMailContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
    public class Message
    {
        public Message() { this.Contacts = new List<Contact>(); }
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public virtual IList<Contact> Contacts { get; set; } //as 'To' field.
    }

    public class Contact
    {
        public Contact() { this.Messages = new List<Message>(); }
        public int ID { get; set; }
        public string Name { get; set; }
        public string MailAddress {get; set;}
        public virtual IList<Message> Messages { get; set; }
    }

}
