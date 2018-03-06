using System;  
using System.Collections.Generic;  
using System.ComponentModel;  
using System.Data;  
using System.Drawing;  
using System.Linq;  
using System.Text;  
using System.Windows.Forms;  
using System.Data.Sql;  
using System.Data.OleDb;  
using System.Data.SqlClient;
using LoginApplication;
using LoginApplication.DAO;

namespace MenuManagerApplication
{
    
    public partial class FormLogin : Form
    {
        SqlConnection con = new SqlConnection();
        
        public FormLogin()
        {
            con.ConnectionString = "Data Source=Thuat-PC\\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";

            InitializeComponent();
            Button1.Click += Button1_Click;

        }
        
         private void Button1_Click(object sender, EventArgs e)  
         {  
            
            string userName = textBox1.Text;
            string passWord = textBox2.Text;

            DataTable userLogin = Login(userName, passWord);

            if (userLogin.Rows.Count > 0)
            {
                this.Hide();
                object typeUser = userLogin.Rows[0]["type"];
                FormMenu frmMenu = new FormMenu(typeUser);
                {
                    frmMenu.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }

         }

        private DataTable Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
