﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Concrete
{
    public partial class FrmCustomerManage : Form
    {
        public FrmCustomerManage()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCustomerManage_Load(object sender, EventArgs e)
        {
            language.Persian();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSubmit.Enabled = false;
            cmbSearch.Focus();
            txtName.Enabled = false;
            txtFamily.Enabled = false;
            txtKmeli.Enabled = false;
            txt_tell.Enabled = false;
            txt_mobile.Enabled = false;
            txt_address.Enabled = false;
        }
    }
}
