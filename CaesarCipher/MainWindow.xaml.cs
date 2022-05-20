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

namespace CaesarCipher
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

        private void cryptBtn_Click(object sender, RoutedEventArgs e)
        {
            byte key;

            if (Validation.isEmpty(decryptInput.Text, keyInput.Text))
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz");
                return;
            }
            try { key = Convert.ToByte(keyInput.Text); }
            catch
            {
                MessageBox.Show("Lütfen anahtar sayını 0 ile 255 arasında giriniz.");
                return;
            }

            Caesar caesar = new Caesar(decryptInput.Text, key);
            String encryptedMessage = caesar.encrypt();
            encryptInput.Text = encryptedMessage;
        }

        private void decryptBtn_Click(object sender, RoutedEventArgs e)
        {
            byte key;

            if (Validation.isEmpty(encryptInput.Text, keyInput.Text))
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz");
                return;
            }
            try { key = Convert.ToByte(keyInput.Text); }
            catch
            {
                MessageBox.Show("Lütfen anahtar sayını 0 ile 255 arasında giriniz.");
                return;
            }

            Caesar caesar = new Caesar(encryptInput.Text, key);
            String decryptedMessage = caesar.decrypt();
            decryptInput.Text = decryptedMessage;
        }

        private void decryptClear_Click(object sender, RoutedEventArgs e)
        {
            decryptInput.Clear();
        }

        private void encryptClear_Click(object sender, RoutedEventArgs e)
        {
            encryptInput.Clear();
        }
    }
}