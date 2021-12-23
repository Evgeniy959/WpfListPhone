﻿using System.Collections.ObjectModel;
using System.Windows;

namespace WpfListPhone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static ObservableCollection<Person> _list;
        public MainWindow()
        {
            InitializeComponent();
            _list = new ObservableCollection<Person>();
            ListOfPhone.ItemsSource = _list;
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MainPerson form = new MainPerson();
            form.Show();
        }

        public static void AddToList(Person newPerson)
        {
            _list.Add(newPerson);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            _list.Clear();
        }
    }
    /*public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phones { get; set; }

    }*/
}
