using System.Collections.ObjectModel;
using System.Windows;
using myMailLibrary;
using System.ComponentModel;
using System;
using System.Linq;
using System.Collections.Generic;

namespace myMailClient
{
    public partial class WPF_AddressBook : Window
    {

        public ObservableCollection<Contact> Contacts { get; set; } = new ObservableCollection<Contact>();
        public Contact Selected { get; set; } = new Contact();
        public WPF_AddressBook()
        {
            InitializeComponent();
            SizeToContent = SizeToContent.WidthAndHeight;
            DataContext = this;
            LoadContacts(new myMessageService().getContacts());
        }
        private void LoadContacts(IEnumerable<Contact> contact_list)
        {
            Contacts.Clear();
            foreach (var contact in contact_list)
            {
                Contacts.Add(contact);
            }
        }
        private void OnTextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (SearchText.Text.Equals(string.Empty))
                LoadContacts(new myMessageService().getContacts());
            else
            {
                IEnumerable<Contact> filtered = new List<Contact>(
                Contacts.Where(contact => contact.Name.ToLower().StartsWith(SearchText.Text.ToLower()))
                );
                LoadContacts(filtered);
            }
        }
        private void btn_new(object sender, RoutedEventArgs e)
        {
            WPF_NewContact window = new WPF_NewContact();
            bool? result = window?.ShowDialog();
            if (result ?? true)
            {
                Contact contact = Contacts.FirstOrDefault(c => c?.ID == Selected?.ID || c?.MailAddress == Selected?.MailAddress);
                if (contact != null)
                    return;
                Contacts.Add(window.NewContact);
                new myMessageService().addNewContact(window.NewContact);
            }
        }
        private void btn_remove(object sender, RoutedEventArgs e)
        {
            Contact contact = Contacts.FirstOrDefault(c => c?.ID == Selected?.ID);
            if (contact == null)
                return;
            new myMessageService().removeContact(contact);
            Contacts.Remove(contact);
        }
        private void btn_select(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}
