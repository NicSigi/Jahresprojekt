﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glücksspielapp
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Willkommen im Glücksspiel-App!";
        }

        private void BtnPlayRoulette_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Roulette starten!");
        }

        private void BtnPlayMines_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mines starten!");
        }

        private void BtnPlayBlackjack_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Blackjack starten!");
        }


    }
}
