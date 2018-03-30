using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document;
using LoginApplication.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApplication
{
    public partial class ReportForm : Form
    {
        private string _dateReport;
        public ReportForm(string dateReport)
        {
            this._dateReport = dateReport;
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            viewer1.GalleyMode = true;

            viewer1.LoadDocument(Application.StartupPath + @"\..\..\MenuReport.rdlx");

        }
    }
}
