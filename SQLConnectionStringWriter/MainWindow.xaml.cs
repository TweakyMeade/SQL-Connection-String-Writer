using System.Windows;
using Microsoft.Data.SqlClient;
namespace SQLConnectionStringWriter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Generate_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = DataSource.Text;
            builder.UserID = UserID.Text;
            builder.Password = Password.Text;
            builder.InitialCatalog = InitialCatalog.Text;
            builder.TrustServerCertificate = (bool)TrustServerCertificate.IsChecked;
            ConnectionString.Text = builder.ConnectionString;
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Clipboard_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(ConnectionString.Text);
        }
    }
}