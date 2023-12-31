﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLSV_OOP.DTO;
using QLSV_OOP;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing.Text;
using System.Windows.Forms;

namespace QLSV_OOP.DAO
{
    public class HTTTDAO
    {
        private static HTTTDAO instance;
        public static HTTTDAO Instance
        {
            get
            {
                if (instance == null) instance = new HTTTDAO();
                return instance;
            }
            private set => instance = value;
        }
        private HTTTDAO() { }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public DataTable htttGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from HTTT", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable SearchHTTT(string nganhang, string stk)
        {
            string query = "SELECT * FROM HTTT WHERE ";
            bool isFirstCondition = true;

            if (!string.IsNullOrEmpty(nganhang))
            {
                query += $"TenNH LIKE '%{nganhang}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(stk))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"STK LIKE '%{stk}%'";
                isFirstCondition = false;
            }

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }
        public void UpdateInfoTTInfo(string newbankname, string newSTK)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE HTTT SET TenNH = @TenNH WHERE STK = @STK_Truong", con))
                {
                    cmd.Parameters.AddWithValue("@TenNH", newbankname);
                    cmd.Parameters.AddWithValue("@STK_Truong", newSTK);

                    // Thêm điều kiện cập nhật (ví dụ: WHERE TenNH = 'Tên Ngân Hàng' AND STK_Truong = 'Số Tài Khoản')
                    // Điều kiện này phải phản ánh cấu trúc chính xác của bảng HTTT trong cơ sở dữ liệu của bạn.

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã cập nhật thông tin hình thức thanh toán thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không có hình thức thanh toán nào được cập nhật. Có thể không tìm thấy thông tin tương ứng hoặc điều kiện cập nhật không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL
                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteHTTT(string stk)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM HTTT WHERE STK = @STK", con))
            {
                cmd.Parameters.AddWithValue("@STK", stk);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void AddHTTT(string bank, string STK)
        {
            // Thêm một hình thức thanh toán mới vào cơ sở dữ liệu
            // Sử dụng SqlCommand để thực hiện câu truy vấn INSERT
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO HTTT (TenNH, STK) VALUES (@TenNH, @STK)", con))
                {
                    cmd.Parameters.AddWithValue("@TenNH", bank);
                    cmd.Parameters.AddWithValue("@STK", STK);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                MessageBox.Show("Đã thêm hình thức thanh toán mới thành công!");
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL
                if (ex.Number == 2627)  // 2627 là mã lỗi cho việc vi phạm ràng buộc duy nhất (unique constraint)
                {
                    MessageBox.Show($"Số tài khoản '{STK}' đã tồn tại trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi khác (nếu có)
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đảm bảo rằng kết nối sẽ được đóng dù có lỗi hay không
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
