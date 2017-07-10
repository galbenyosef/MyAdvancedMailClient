using myMailLibrary;
using System.Windows;

namespace myMailClient
{
    /// <summary>
    /// Interaction logic for WPF_NewContact.xaml
    /// </summary>
    public partial class WPF_NewContact : Window
    {
        public Contact NewContact { get; set; } = new Contact();
        public string NewName { get; set; } = string.Empty;
        public string NewMail { get; set; } = string.Empty;
        public WPF_NewContact()
        {
            InitializeComponent();
            SizeToContent = SizeToContent.WidthAndHeight;
            DataContext = this;
        }
        private void btn_add(object sender, RoutedEventArgs e)
        {
            NewContact.Name = NewName;
            NewContact.MailAddress = NewMail;
            DialogResult = true;
            Close();
        }

    }
}

