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
    public partial class frmChangePassword : Form
    {
        private Account account;
        public frmChangePassword(Account acc)
        {
            InitializeComponent();
            account = acc;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            txtMatKhauCu.Text = "Nhập mật khẩu cũ";
            txtMatKhauCu.ForeColor = Color.Silver;
            txtMatKhauMoi.Text = "Nhập mật khẩu mới";
            txtMatKhauMoi.ForeColor = Color.Silver;
            txtNhapLai.Text = "Nhập lại mật khẩu mới";
            txtNhapLai.ForeColor = Color.Silver;
           
        }
        private void txtMatKhauCu_Enter(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text == "Nhập mật khẩu cũ")
            {
                txtMatKhauCu.Text = "";
                txtMatKhauCu.ForeColor = Color.Black;

            }
        }
        private void txtMatKhauCu_Leave(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text == "")
            {
                txtMatKhauCu.Text = "Nhập mật khẩu cũ";
                txtMatKhauCu.ForeColor = Color.Silver;
            }
            else if (txtMatKhauCu.Text != account.Password )
            {
                MessageBox.Show("Sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhauCu.Text = "Nhập mật khẩu cũ";
                txtMatKhauCu.ForeColor = Color.Silver;
                
            }
            
        }
        private void txtMatKhauMoi_Enter(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text == "Nhập mật khẩu mới")
            {
                txtMatKhauMoi.Text = "";
                txtMatKhauMoi.ForeColor = Color.Black;

            }
            
        }

        private void txtMatKhauMoi_Leave(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text == "")
            {
                txtMatKhauMoi.Text = "Nhập mật khẩu mới";
                txtMatKhauMoi.ForeColor = Color.Silver;
            }
               
        }

        private void txtNhapLai_Enter(object sender, EventArgs e)
        {
            if (txtNhapLai.Text == "Nhập lại mật khẩu mới")
            {
                txtNhapLai.Text = "";
                txtNhapLai.ForeColor = Color.Black;

            }
        }

        private void txtNhapLai_Leave(object sender, EventArgs e)
        {
            if (txtNhapLai.Text == "")
            {
                txtNhapLai.Text = "Nhập lại mật khẩu mới";
                txtNhapLai.ForeColor = Color.Silver;
            }
            else if (txtNhapLai.Text != txtMatKhauMoi.Text && txtMatKhauMoi.Text != "" && txtMatKhauMoi.Text != "Nhập mật khẩu mới")
            {
                MessageBox.Show("Gõ lại mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhapLai.Text = "Nhập lại mật khẩu mới";
                txtNhapLai.ForeColor = Color.Silver;
            }
      
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            
                if (txtMatKhauCu.Text == account.Password && AccountDAO.Instance.UpdatePassword(account.UserName, account.Password, txtMatKhauMoi.Text))
                {
                    MessageBox.Show("Cập nhật mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    account.Password = txtMatKhauMoi.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMatKhauCu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
