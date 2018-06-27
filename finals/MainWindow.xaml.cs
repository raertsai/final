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

namespace finals
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string filePath = "";

        public MainWindow()
        {
            InitializeComponent();
        }
        private void sent_click(object sender, RoutedEventArgs e)
        {
            Textarea.Text = " ";
            MessageBox.Show(name.Text+" "+"has received your letter");
            name.Text = " ";
        }

        private void pic_click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dig = new Microsoft.Win32.SaveFileDialog();

            // open save window
            Nullable<bool> result = dig.ShowDialog();

            if (result == true)
            {
                filePath = dig.FileName;
                System.IO.File.WriteAllText(dig.FileName, Textarea.Text);
            }
        }
        }  
    }

