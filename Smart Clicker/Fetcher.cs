﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Smart_Clicker
{
    public partial class Fetcher : Form
    {
        private MainForm mainForm;

        public Fetcher(MainForm mainForm) //, CustomizationParameters parameters)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.ShowInTaskbar = false;
            mainForm.Move += new EventHandler(move_On_Main_Form);
            this.StartPosition = FormStartPosition.Manual;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ControlBox = false;
            this.MinimumSize = new Size(10, 10);
            this.Size = new Size(25, 25);   //(parameters.clickValues.clickBoundingBox, parameters.clickValues.clickBoundingBox);
            this.Location = new Point(this.mainForm.Location.X, this.mainForm.Location.Y - this.Size.Height);
            this.TopMost = true;
        }

        private void Fetcher_Load(object sender, EventArgs e)
        {

        }

        private void move_On_Main_Form(object sender, EventArgs e)
        {
            this.Location = new Point(this.mainForm.Location.X, this.mainForm.Location.Y - this.Size.Height);
        }

        private void Fetcher_MouseEnter(object sender, EventArgs e)
        {
            this.mainForm.Activate();
        }
    }
}
