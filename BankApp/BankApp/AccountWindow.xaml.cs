using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BankApp
{
   
    public partial class AccountWindow : Window
    {
        public MainWindow Mainwindow;

        public AccountWindow()
        {
            
            
            InitializeComponent();
            Mainwindow = Application.Current.MainWindow as MainWindow;
            MoneyLabel.Content = $"{Mainwindow.CurrentUser.Money} PLN";
            UserLabel.Content = Mainwindow.CurrentUser.Username;

            for (int i = 0; i < Mainwindow.UsersList.Count; i += 1)
            {
                if (Mainwindow.UsersList[i].Username != Mainwindow.CurrentUser.Username)
                {
                    TransferListBox.Items.Add(Mainwindow.UsersList[i]);
                }

            }
        }
        public void Refresh()
        {
            MoneyLabel.Content = $"{Mainwindow.CurrentUser.Money} PLN";
        }

        private void RefreshAfterTransfer()
        {
            MoneyLabel.Content = $"{Mainwindow.CurrentUser.Money} PLN";
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
            Mainwindow.Show();
            Refresh();
        }
        private void TransferListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            TransferToLabel.Content = "Transfer to:" + (TransferListBox.SelectedItem as User).Username;
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            var window = Application.Current.MainWindow as MainWindow;
            User Checked = TransferListBox.SelectedItem as User;
            int TransferMoney;
            bool MoneyChecker = int.TryParse(AmountInput.Text, out TransferMoney);

            if (MoneyChecker)
            {
                if (TransferMoney <= Mainwindow.CurrentUser.Money)
                {
                    Checked.Money += TransferMoney;
                    Mainwindow.CurrentUser.Money -= int.Parse(AmountInput.Text);
                    MessageBox.Show("Transfer sended succesfully!");

                }
                else
                {
                    MessageBox.Show("Lack of account funds", "Transfer Error");
                }

            }
            else MessageBox.Show("You must enter the amount!", "Invalid format");

            RefreshAfterTransfer();
            Mainwindow.FileRefresh();
        }

        
    }
}
