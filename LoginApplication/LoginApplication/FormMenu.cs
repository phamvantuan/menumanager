using LoginApplication;
using LoginApplication.DAO;
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

namespace MenuManagerApplication
{
    public partial class FormMenu : Form
    {
      
        public int _typeUser { get; private set; }
        public FormMenu(object typeUser)
        {
            this._typeUser = int.Parse(typeUser.ToString());
            InitializeComponent();
            
            loadData(true);
        }
        
        public string UID { get; private set; }

         void loadData(bool isCheckAdmin)
        {
            string theDate = dateMenu.Value.ToString("yyyy-MM-dd");
            
            DataTable data = DataProvider.Instance.ExecuteQuery("select [id], [name], [price] from [menu] where created = '" + theDate + "' ");

            if (isCheckAdmin)
            {
                if (_typeUser == (int)UserType.UserTypes.Admin)
                {
                    btnAddMenu.Visible = true;
                    btnDeleteMenu.Visible = true;
                }
            }

            if (data.Rows.Count > 0)
            {
                lgvMenu.DataSource = data;
                lgvMenu.Columns["id"].Visible = false;
            }
            else
            {
                lgvMenu.DataSource = null;
                btnDeleteMenu.Visible = false;
                btnPrint.Hide();
            }
           
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {

            FormAddMenu frmAddMenu = new FormAddMenu(this);
            {
                frmAddMenu.Show();
            }
            
        }

        private string CreateQueryUpdateDataForMenu(string name, int price,string date, bool isUpdate, int id)
        { 
            if (isUpdate) return "update dbo.menu set name = '" + name + "', price = "+ price + " where id = " + id ;

            return "INSERT INTO [Restaurant].[dbo].[menu]([menu].[name],[menu].[price],[menu].[created]) VALUES('" + name + "'," + price + ",'" + date + "')";
         
        }

        private bool CheckisInsertOrUpdate(int id)
        {
            return id > 0;
        }

        private void lgvMenu_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_typeUser == (int)UserType.UserTypes.Admin)
            {
                int id = 0;
                int price = 0;
                string name = null;
                bool IsUpdateOrInsert = false;

                string columnName = lgvMenu.Columns[e.ColumnIndex].HeaderText;
                
                if (!string.IsNullOrEmpty(lgvMenu["id", e.RowIndex].Value.ToString()))
                {
                    id = (int)lgvMenu["id", e.RowIndex].Value;
                    IsUpdateOrInsert = CheckisInsertOrUpdate(id);
                }

                if (!string.IsNullOrEmpty(lgvMenu["name", e.RowIndex].Value.ToString()))
                {
                    name = (string)lgvMenu["name", e.RowIndex].Value;
                }
                if (!string.IsNullOrEmpty(lgvMenu["price", e.RowIndex].Value.ToString()))
                {
                    price = (int)lgvMenu["price", e.RowIndex].Value;
                }

                string date = dateMenu.Value.ToString("yyyy-MM-dd");

                try
                {
                    if (name != null && price > 0)
                    {
                        string query = CreateQueryUpdateDataForMenu(name, price, date, IsUpdateOrInsert, id);
                        DataProvider.Instance.ExecuteNonQuery(query);
                        loadData(false);
                    }
                }
                catch
                {
                    //Error when save data
                    MessageBox.Show("Error to save on database");
                }
            }
            else
            {
                loadData(false);
                MessageBox.Show("You don't have permission update");
            }
            
        }

        private void btnDeleteMenu_Click(object sender, EventArgs e)
        {
            
            if (lgvMenu.Rows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure delete this?", "Delete Menu", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    int rowIndex = lgvMenu.CurrentCell.RowIndex;
                    int id = 0;

                    id = (int)lgvMenu.Rows[rowIndex].Cells["id"].Value;
                    try
                    {
                        if (id > 0)
                        {
                            DataProvider.Instance.ExecuteNonQuery("delete from dbo.menu where id = " + id);
                            loadData(false);
                        }
                    }
                    catch
                    {
                        //Error when save data
                        MessageBox.Show("Error to save on database");
                    }
                }
            }
        }

        private void lgvMenu_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Delete)
            {
                btnDeleteMenu_Click(sender, e);
            }
        }

        private void dateMenu_ValueChanged(Object sender, EventArgs e)
        {
            loadData(false);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            Bitmap bm = getsizeDataGridView();

            lgvMenu.DrawToBitmap(bm, new Rectangle(0, 0, lgvMenu.Width, lgvMenu.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private Bitmap getsizeDataGridView()
        {
            int height = 0;
            foreach (DataGridViewRow row in lgvMenu.Rows)
            {
                height += row.Height;
            }
            height += lgvMenu.ColumnHeadersHeight;

            int width = 0;
          
            foreach (DataGridViewColumn col in lgvMenu.Columns)
            {
                    width += col.Width;
            }

            Bitmap bm = new Bitmap(width,height);
            return bm;
        }
    }
}
