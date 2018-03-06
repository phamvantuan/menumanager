using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginApplication.DAO;

namespace MenuManagerApplication
{
    public partial class FormAddMenu : Form
    {
        
        private FormMenu fmenu;
        public FormAddMenu(FormMenu fmenu)
        {
            InitializeComponent();
            this.fmenu = fmenu;
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim().ToString();
            string price = txtPrice.Text.Trim().ToString();
            string date = choseDate.Value.ToString("yyyy-MM-dd");
            
            string dateSelect = fmenu.dateMenu.Value.ToString("yyyy-MM-dd");
            
            try
            {
                string query = "INSERT INTO [Restaurant].[dbo].[menu]([menu].[name],[menu].[price],[menu].[created]) VALUES('" + name + "','" + price + "','" + date + "')";
                DataProvider.Instance.ExecuteNonQuery(query);
                this.Close();

                string query1 = "select [id],[name],[price] from [menu] where created = '" + dateSelect + "' ";

                DataTable data = DataProvider.Instance.ExecuteQuery(query1);
               
                fmenu.lgvMenu.DataSource = data;
                fmenu.lgvMenu.Columns["id"].Visible = false;
                fmenu.btnDeleteMenu.Visible = true;
            }
            catch
            {
                //Error when save data
                MessageBox.Show("Error to save on database");
            }
        }
    }
}
