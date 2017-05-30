using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;

namespace DXApplication2 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXWindow {
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            // So kommt der Fokus wieder zurueck auf den Button
            //ActivatePanel();

            // So bleibt der Fokus auf dem anderen Panel
            Dispatcher.BeginInvoke((Action) ActivatePanel);
        }

        void ActivatePanel() {
            dlm.MDIController.Restore(panel);
            panel.IsActive = true;
        }

        private void panel_GotFocus(object sender, RoutedEventArgs e) {
            log("got focus");
        }

        private void panel_LostFocus(object sender, RoutedEventArgs e) {
            log("lost focus");
        }

        void log(string text) {
            output.AppendText(text + Environment.NewLine);
        }
    }
}
