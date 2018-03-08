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
            string name = txtName.Text.ToString().Trim();
            string price = txtPrice.Text.ToString().Trim();

            int n;
            bool isNumeric = int.TryParse(price, out n);
          
            if (name.Length <= 0 || price.Length <= 0)
            {
                MessageBox.Show("Data is not empty!");
            }
            else if (!isNumeric)
            {
                MessageBox.Show("Price invalid!");
            }
            else
            {
                string date = choseDate.Value.ToString("yyyy-MM-dd");
                string query = "INSERT INTO [Restaurant].[dbo].[menu]([menu].[name],[menu].[price],[menu].[created]) VALUES('" + name + "','" + price + "','" + date + "')";
                DataProvider.Instance.ExecuteNonQuery(query);
                this.Close();
                fmenu.loadData(true);
            }
        }
    }
}
