using System.IO;
using System.Net.Http;
using System.Text;
using System.Windows;

namespace Chapter1.WPF
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var httpClient = new HttpClient();

            string content = await httpClient
                .GetStringAsync("http://www.microsoft.com")
                .ConfigureAwait(false);

            Output.Content = content;
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var httpClient = new HttpClient();

            string content = await httpClient
                .GetStringAsync("http://www.microsoft.com")
                .ConfigureAwait(false);

            using (var sourceStream = new FileStream("temp.html",
                FileMode.Create, FileAccess.Write, FileShare.None,
                4096, true))
            {
                byte[] encodedText = Encoding.Unicode.GetBytes(content);
                await sourceStream.WriteAsync(encodedText, 0, encodedText.Length)
                    .ConfigureAwait(false);
            }
            ;
        }
    }
}