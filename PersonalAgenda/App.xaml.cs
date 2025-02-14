﻿using System;
using PersonalAgenda.Data;
using System.IO;
using Xamarin.Forms;
namespace PersonalAgenda
{
    public partial class App : Application
    {
        static AgendaDatabase database;
        public static AgendaDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new
                   AgendaDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                   LocalApplicationData), "Notes.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new AgendaPage());
        }
    }
}