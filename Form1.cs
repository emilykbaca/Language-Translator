﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Language_Translator
{
    public partial class languageTranslatorForm : Form
    {
        public languageTranslatorForm()
        {
            InitializeComponent();
        }

        private void italianButton_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Buoungiorno";
        }

        private void spanishButton_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Buenos Dias";
        }

        private void germanButton_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Guten Morgen";
        }
    }
}
