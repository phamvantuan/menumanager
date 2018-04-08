using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Configuration;
using GrapeCity.ActiveReports.Document;
using GrapeCity.ActiveReports.SectionReportModel;
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
        SectionReport rpt;

        private void ReportForm_Load(object sender, EventArgs e)
        {

            rpt = new SectionReport();

            //Adding Page Header/Footer sections
            rpt.Sections.InsertPageHF();
            rpt.Sections[0].BackColor = Color.LightGray;

            //Adding Detail section
            rpt.Sections.Insert(1, new Detail());
            rpt.Sections[1].BackColor = Color.PeachPuff;
            rpt.Sections[1].Height = 0.5f;
            
            //Adding label to display first column's name
            GrapeCity.ActiveReports.SectionReportModel.Label lblCategoryID = new GrapeCity.ActiveReports.SectionReportModel.Label();
            lblCategoryID.Location = new PointF(0, 0.05F);
            lblCategoryID.Text = "Tên món ăn";
            lblCategoryID.Alignment = GrapeCity.ActiveReports.Document.Section.TextAlignment.Center;
            lblCategoryID.Font = new Font("Arial", 10, FontStyle.Bold);
            rpt.Sections[0].Controls.Add(lblCategoryID);

            //Adding label to display second column's name
            GrapeCity.ActiveReports.SectionReportModel.Label lblCategoryName = new GrapeCity.ActiveReports.SectionReportModel.Label();
            lblCategoryName.Location = new PointF(1.459f, 0.05f);
            lblCategoryName.Size = new SizeF(1.094f, 0.2f);
            lblCategoryName.Text = "Giá";
            lblCategoryName.Font = new Font("Arial", 10, FontStyle.Bold);
            rpt.Sections[0].Controls.Add(lblCategoryName);


            // Adding Textbox to display first column's records
            GrapeCity.ActiveReports.SectionReportModel.TextBox txtCategoryID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            txtCategoryID.Location = new PointF(0, 0);
            txtCategoryID.Alignment = GrapeCity.ActiveReports.Document.Section.TextAlignment.Center;
            rpt.Sections[1].Controls.Add(txtCategoryID);

            //Adding Textbox to display second column's records
            GrapeCity.ActiveReports.SectionReportModel.TextBox txtCategoryName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            txtCategoryName.Location = new PointF(1.459f, 0);
            rpt.Sections[1].Controls.Add(txtCategoryName);

            // Setting report's data source
            rpt.DataSource = DataProvider.Instance.ExecuteQuery("select * from dbo.menu where created ='" + _dateReport + "' ");

            // Assigning DataField properties of controls in the detail section
            txtCategoryID.DataField = "name";
            txtCategoryName.DataField = "price";

            rpt.Run();
            this.viewer1.Document = rpt.Document;

        }

        //PageDocument runtime;
        //private void LoadReport()
        //{

        //    FileInfo rptPath = new FileInfo(@"..\..\MenuReport.rdlx");
        //    PageReport definition = new PageReport(rptPath);

        //    definition.ConfigurationProvider = new DefaultConfigurationProvider();
        //    runtime = new PageDocument(definition);
        //    runtime.LocateDataSource += new LocateDataSourceEventHandler(runtime_LocateDataSource);
        //    viewer1.LoadDocument(runtime);
        //}

        //void runtime_LocateDataSource(object sender, LocateDataSourceEventArgs args)
        //{
        //    DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.menu");
        //    //da.Fill(table);
        //    args.Data = data;
        //}

        public ReportForm(string dateReport)
        {
            this._dateReport = dateReport;
            InitializeComponent();
        }


        //private void ReportForm_Load(object sender, EventArgs e)
        //{
        //    LoadReport();
        //}


    }

}
