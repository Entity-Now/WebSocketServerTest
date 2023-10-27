using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WebSocketServerTest.Core;


namespace WebSocketServerTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PrintMsg.Send += OnMessage;
        }

        void OnMessage(string msg)
        {
            Dispatcher.BeginInvoke(new Action(() =>
            {
                receiveMsg.AppendText($"\n {msg}");
            }));
        }

        private void Listen_Click(object sender, RoutedEventArgs e)
        {
            Ws.WssStart($"{protocol.SelectedItem.ToString()}://127.0.0.1:{port.Text}");
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            Ws.Stop();
        }
    }
}
