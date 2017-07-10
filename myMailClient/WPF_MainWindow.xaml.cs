using myMailLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Windows;

namespace myMailClient
{
    public partial class WPF_MainWindow : Window , INotifyPropertyChanged
    {
        public ObservableCollection<Message> Messages { get; set; } = new ObservableCollection<Message>();
        public ObservableCollection<Contact> MessageContacts { get; set; } = new ObservableCollection<Contact>();
        private Message selected { get; set; } = new Message();
        public Message Selected
        {
            get { return selected; }

            set
            {
                if (value == null)
                    return;
                if (value != selected)
                {
                    MessageContacts.Clear();
                    selected.Subject = value.Subject;
                    selected.Body = value.Body;
                    selected.Date = value.Date;
                    selected.ID = value.ID;
                    foreach (var c in new myMessageService().getMessageContacts(selected.ID))
                    {
                        Contact contact = new Contact();
                        contact.ID = c.ID;
                        contact.MailAddress = c.MailAddress;
                        contact.Name = c.Name;
                        contact.Messages = new List<Message>();
                        MessageContacts.Add(contact);
                    }
                    selected.Contacts = new List<Contact>(MessageContacts);
                    NotifyPropertyChanged("Selected");
                }
            }
        }
        public WPF_MainWindow()
        {
            InitializeComponent();
            this.SizeToContent = SizeToContent.WidthAndHeight;
            DataContext = this;
            LoadMessages(new myMessageService().getMessages());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        private void LoadMessages(IEnumerable<Message> msg_list)
        {
            Messages.Clear();
            foreach (var msg in msg_list)
            {
                Messages.Add(msg);
            }
        }
        private void btn_new(object sender, RoutedEventArgs e)
        {
            WPF_NewMessage window;
            window = new WPF_NewMessage();
            bool? result = window?.ShowDialog();
            if (result ?? true)
            {
                Messages.Add(window.Message);
                new myMessageService().addNewMessage(window.Message);
            }
        }
        private void btn_del(object sender, RoutedEventArgs e)
        {
            Message message = Messages.FirstOrDefault(m => m.ID == Selected?.ID);
            if (message == null)
                return;
            new myMessageService().removeMessage(message);
            Messages.Remove(message);
        }
        private void btn_send(object sender, RoutedEventArgs e)
        {
            if (selected == null)
                return;
            try
            {
                PostSendMail();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void PostSendMail()
        {
            using (var c = new HttpClient())
            {
                var contentStr = JsonConvert.SerializeObject(selected);
                var message = new StringContent(contentStr, System.Text.Encoding.UTF8, "application/json");
                var response = c.PostAsync("http://localhost:7001/api/mailsender", message).Result;

                var result = response.Content.ReadAsStringAsync().Result;
                //if (result != "Ok")
                //    throw new Exception(result);
            }
        }
    }
}
