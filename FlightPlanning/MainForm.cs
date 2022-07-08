using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FlightPlanning.Models;
using FlightPlanning.Logic;

namespace FlightPlanning
{
    public partial class MainForm : Form
    {
        private Database db;
        private User currentUser;
        public MainForm(Database database)
        {
            InitializeComponent();
            db = database;
            currentUser = database.loggedInUser;

            SetUpAccountGroup();
        }

