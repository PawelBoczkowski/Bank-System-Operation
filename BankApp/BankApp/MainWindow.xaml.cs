﻿using System;
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

namespace BankApp
{

    public partial class MainWindow : Window
    {
        public User CurrentUser;
        public List<User> UsersList = new List<User>();
        readonly string File = "‪data.txt";
        AccountWindow AccWindow;

        public MainWindow()
        {
            InitializeComponent();
            ReadFromFile();
            
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginInput.Text;
            string password = PasswordInput.Password;

            bool logged = false;

            for (int i = 0; i < UsersList.Count(); i += 1)
            {
                if (login == UsersList[i].Username)
                {
                    if (password == UsersList[i].PasswordHash)
                    {

                        CurrentUser = UsersList[i];
                        logged = true;
                        AccWindow = new AccountWindow();
                        AccWindow.Show();
                        Hide();
                        break;
                    }
                }
            }

            if (!logged)
                MessageBox.Show("Wrong login or password!");

        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string username = LoginInput.Text;
            string password = PasswordInput.Password;
            bool finded = false;

            if (username.Length < 3)
            {
                MessageBox.Show("Login is too short!", "Error!");
                return;
            }

            for (int i = 0; i < UsersList.Count; i += 1)
            {
                if (username == UsersList[i].Username)
                {
                    finded = true;
                    MessageBox.Show("Login exist!", "Error!");
                }

            }
            if (!finded)
            {
                RegisterMessage.Content = $"Registered Succesfully!";
                AddToUsersList(new User(username, password));
                SaveToFile();

            }

        }
        private void AddToUsersList(User NewUser)
        {
            UsersList.Add(NewUser);
        }

        private void SaveToFile()
        {
            var file = new System.IO.StreamWriter(File, true, System.Text.Encoding.UTF8);
            file.WriteLine(LoginInput.Text + " " + PasswordInput.Password);
            file.Close();
        }
        public void FileRefresh()
        {
            var Refresh_file = new System.IO.StreamWriter(File, false, System.Text.Encoding.UTF8);
            for (int i = 0; i < UsersList.Count(); i += 1)
            {
                Refresh_file.WriteLine(UsersList[i].Username + " " + UsersList[i].PasswordHash + " " + UsersList[i].Money);
            }

            Refresh_file.Close();


        }
        public void ReadFromFile()
        {
            var ReadFile = new System.IO.StreamReader(File, System.Text.Encoding.UTF8);
            string text;
            do
            {
                text = ReadFile.ReadLine();
                if (text != null)
                {
                    AddToUsersList(new User(text.Split()[0], text.Split()[1]));
                }

            } while (text != null);

        }

        private void LoginInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            RegisterMessage.Content = "";
        }
    }
}
