﻿using QLSV_OOP.DAO;
using QLSV_OOP.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_OOP
{
    public partial class frmAdmin : Form
    {
        private Account account;
        public frmAdmin(Account acc)
        {
            InitializeComponent();
            account = acc;
            accountManagement1.Visible = false;
            studentManagement1.Visible = false;
            employeeManagement1.Visible = false;
            adminManagement1.Visible = false;
        }


        private void toolStripMenuItemSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }
        

        private void changePasswordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FunctionMenuStrip.Instance.ChangePassword(this, account);
        }

        private void accountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FunctionMenuStrip.Instance.AccountAnalysis(this);
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FunctionMenuStrip.Instance.StudentAnalysis(this);
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accountManagement1.ResetState();
            accountManagement1.Visible = true;
            studentManagement1.Visible = false;
            studentManagement1.ResetState();
            employeeManagement1.Visible = false;
            employeeManagement1.ResetState();
            adminManagement1.Visible = false;
            adminManagement1.ResetText();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentManagement1.ResetState();
            studentManagement1.Visible = true;
            accountManagement1.Visible = false;
            accountManagement1.ResetState();
            employeeManagement1.Visible=false;
            employeeManagement1.ResetState();
            adminManagement1.Visible = false;
            adminManagement1.ResetText();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employeeManagement1.ResetState();
            employeeManagement1.Visible = true;
            accountManagement1.Visible =false;
            accountManagement1.ResetState();
            studentManagement1.Visible=false;
            studentManagement1.ResetState();
            adminManagement1.Visible = false;
            adminManagement1.ResetText();
        }
        private void employeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FunctionMenuStrip.Instance.EmployeeAnalysis(this);
        }

        private void authorizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FunctionMenuStrip.Instance.RoleChanging(this);
        }

        private void employeeManagement1_Load(object sender, EventArgs e)
        {

        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            personalToolStripMenuItem.ForeColor = Color.Navy;
        }

        private void personalToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            personalToolStripMenuItem.ForeColor = Color.Lavender;
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageToolStripMenuItem.ForeColor = Color.Navy;
        }

        private void manageToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            manageToolStripMenuItem.ForeColor = Color.Lavender;
        }

        private void analyzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            analyzeToolStripMenuItem.ForeColor = Color.Navy;
        }

        private void analyzeToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            analyzeToolStripMenuItem.ForeColor = Color.Lavender;
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employeeManagement1.ResetState();
            employeeManagement1.Visible = false;
            accountManagement1.Visible = false;
            accountManagement1.ResetState();
            studentManagement1.Visible = false;
            studentManagement1.ResetState();
            adminManagement1.ResetState();
            adminManagement1.Visible = true;
            
        }
    }

}
