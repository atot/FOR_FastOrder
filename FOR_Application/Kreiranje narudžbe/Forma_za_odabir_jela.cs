﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kreiranje_narudžbe
{
    public partial class frmOdabirJela : Form
    {
        public frmOdabirJela()
        {
            InitializeComponent();
        }

        private void btnIzlazIzJela_Click(object sender, EventArgs e)
        {
            frmOdabirJela.ActiveForm.Close();
        }
    }
}
