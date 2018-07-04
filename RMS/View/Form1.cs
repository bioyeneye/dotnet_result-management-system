using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.Services;
using Model.ViewModel;
using Telerik.WinControls.UI;

namespace RMS.View
{
    public partial class Form1 : Form
    {
        private readonly IUserService _userService;
        public WaitingForm WaitingForm { get; set; }
        public Form1(IUserService userService)
        {
            _userService = userService;

            InitializeComponent();

            int page = 1;
            int count = 10;
            ((PagingPanelElement)(radGridView1.GetChildAt(0).GetChildAt(0).GetChildAt(1))).NumericButtonsCount = 5;
            radGridView1.MasterTemplate.EnableFiltering = true; radGridView1.MasterTemplate.EnablePaging = true;
            radGridView1.BestFitColumns(BestFitColumnMode.AllCells);
            radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            radGridView1.AutoExpandGroups = true;

            backgroundWorker1 = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += BackgroundWorker1_RunWorkerCompleted;
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Task.Delay(10000);
            radGridView1.DataSource = dataSource;
            ((GridViewDateTimeColumn)this.radGridView1.Columns["CreatedAt"]).FormatString = "{0: yyyy dd mm}";
            WaitingForm.Stop();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            dataSource = _userService.GetCount()
                .OrderByDescending(c => c.Id).ToList();
        }

        private List<UserItem> dataSource;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
                WaitingForm = new WaitingForm();
                WaitingForm.ShowDialog(this);
            }

        }

        private void radGridView1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
