namespace MenuManagerApplication
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.lgvMenu = new System.Windows.Forms.DataGridView();
            this.btnDeleteMenu = new System.Windows.Forms.Button();
            this.dateMenu = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCreateReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Location = new System.Drawing.Point(96, 23);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(100, 23);
            this.btnAddMenu.TabIndex = 0;
            this.btnAddMenu.Text = "Add Menu";
            this.btnAddMenu.UseVisualStyleBackColor = true;
            this.btnAddMenu.Visible = false;
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // lgvMenu
            // 
            this.lgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lgvMenu.Location = new System.Drawing.Point(61, 78);
            this.lgvMenu.Name = "lgvMenu";
            this.lgvMenu.Size = new System.Drawing.Size(763, 309);
            this.lgvMenu.TabIndex = 1;
            this.lgvMenu.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.lgvMenu_CellValueChanged);
            this.lgvMenu.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.lgvMenu_EditingControlShowing);
            this.lgvMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lgvMenu_KeyDown);
            // 
            // btnDeleteMenu
            // 
            this.btnDeleteMenu.Location = new System.Drawing.Point(450, 23);
            this.btnDeleteMenu.Name = "btnDeleteMenu";
            this.btnDeleteMenu.Size = new System.Drawing.Size(103, 23);
            this.btnDeleteMenu.TabIndex = 3;
            this.btnDeleteMenu.Text = "Delete Menu";
            this.btnDeleteMenu.UseVisualStyleBackColor = true;
            this.btnDeleteMenu.Visible = false;
            this.btnDeleteMenu.Click += new System.EventHandler(this.btnDeleteMenu_Click);
            // 
            // dateMenu
            // 
            this.dateMenu.Location = new System.Drawing.Point(220, 26);
            this.dateMenu.Name = "dateMenu";
            this.dateMenu.Size = new System.Drawing.Size(200, 20);
            this.dateMenu.TabIndex = 4;
            this.dateMenu.ValueChanged += new System.EventHandler(this.dateMenu_ValueChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(574, 23);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print Menu";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogout.Location = new System.Drawing.Point(766, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(95, 34);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Location = new System.Drawing.Point(655, 23);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(94, 23);
            this.btnCreateReport.TabIndex = 7;
            this.btnCreateReport.Text = "Create report";
            this.btnCreateReport.UseVisualStyleBackColor = true;
            this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 438);
            this.Controls.Add(this.btnCreateReport);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dateMenu);
            this.Controls.Add(this.btnDeleteMenu);
            this.Controls.Add(this.lgvMenu);
            this.Controls.Add(this.btnAddMenu);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Menu";
            ((System.ComponentModel.ISupportInitialize)(this.lgvMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddMenu;
        public System.Windows.Forms.DataGridView lgvMenu;
        public System.Windows.Forms.Button btnDeleteMenu;
        public System.Windows.Forms.DateTimePicker dateMenu;
        public System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCreateReport;
    }
}