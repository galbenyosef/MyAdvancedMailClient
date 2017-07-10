using myMailLibrary;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace myMailClient
{
    public partial class WPF_NewMessage : Window
    {
        public ObservableCollection<Contact> To { get; set; } = new ObservableCollection<Contact>();
        public string Body { get; set; }
        public string Subject { get; set; }
        public Message Message { get; set; }
        public WPF_NewMessage()
        {
            InitializeComponent();
            SizeToContent = SizeToContent.WidthAndHeight;
            DataContext = this;
        }
        private void btn_add(object sender, RoutedEventArgs e)
        {
            WPF_AddressBook window = new WPF_AddressBook();
            bool? result = window?.ShowDialog();
            if (result ?? true)
            {
                Contact contact = To.FirstOrDefault(m => m.ID == window.Selected?.ID);
                if (contact == null)
                {
                    To.Add(window.Selected);
                    window.Selected = null;
                }
                return;
            }
        }
        private void btn_done(object sender, RoutedEventArgs e)
        {
            Message = new Message();
            Message.Subject = this.Subject;
            foreach (var contact in To)
            {
                Message.Contacts.Add(contact);
            }
            Message.Body = this.Body;
            Message.Date = System.DateTime.Now;
            DialogResult = true;
            Close();
        }
    }
}
