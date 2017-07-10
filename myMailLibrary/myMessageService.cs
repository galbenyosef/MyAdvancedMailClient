
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace myMailLibrary
{
    public class myMessageService
    {
        static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public void addNewContact(Contact contact)
        {
            if (contact == null)
                return;
            using (var db = new myMailContext())
            {
                db.Contacts.Add(contact);
                db.SaveChanges();
            }
        }

        public void removeContact(Contact contact)
        {
            if (contact == null)
                return;
            using (var db = new myMailContext())
            {
                db.Contacts.Attach(contact);
                db.Contacts.Remove(contact);
                db.SaveChanges();
            }
        }

        public void addNewMessage(Message message)
        {
            if (message == null)
                return;
            using (var db = new myMailContext())
            {
                db.Messages.Attach(message);
                db.Messages.Add(message);
                db.SaveChanges();
            }
        }

        public void removeMessage(Message message)
        {
            if (message == null)
                return;
            using (var db = new myMailContext())
            {
                db.Messages.Attach(message);
                db.Messages.Remove(message);
                db.SaveChanges();
            }
        }

        public IList<Contact> getContacts()
        {
            using ( var db = new myMailContext() )
            {
                return new List<Contact>(db.Contacts);
            }
        }

        public IList<Message> getMessages()
        {
            using (var db = new myMailContext())
            {
                return new List<Message>(db.Messages);
            }
        }


        public IList<Contact> getMessageContacts(int m_id)
        {
            using (var db = new myMailContext())
            {
                var ContactInMessage = db.Messages.Where(m => m.ID == m_id)
                                              .SelectMany(c => c.Contacts);
                return new List<Contact>(ContactInMessage);
            }
        }

    }
}