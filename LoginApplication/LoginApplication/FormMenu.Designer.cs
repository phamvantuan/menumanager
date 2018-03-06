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
            this.lgvMenu.Size = new System.Drawing.Size(611, 309);
            this.lgvMenu.TabIndex = 1;
            this.lgvMenu.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.lgvMenu_CellValueChanged);
            this.lgvMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lgvMenu_KeyDown);
            // 
            // btnDeleteMenu
            // 
            this.btnDeleteMenu.Location = new System.Drawing.Point(520, 23);
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
            this.dateMenu.Location = new System.Drawing.Point(253, 23);
            this.dateMenu.Name = "dateMenu";
            this.dateMenu.Size = new System.Drawing.Size(200, 20);
            this.dateMenu.TabIndex = 4;
            this.dateMenu.ValueChanged += new System.EventHandler(this.dateMenu_ValueChanged);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 438);
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
    }
}