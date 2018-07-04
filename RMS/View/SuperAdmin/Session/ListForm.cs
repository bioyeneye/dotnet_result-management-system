using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic.Services;
using Model.ViewModel;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace RMS.View.SuperAdmin.Session
{
    public partial class ListForm : Telerik.WinControls.UI.RadForm
    {
        public static readonly log4net.ILog _logger =
            log4net.LogManager.GetLogger(typeof(ListForm));

        private bool canPerformOtherAction;
        private SectionModel _sectionModel;

        public ISectionService SectionService => Program.container.GetInstance<ISectionService>();

        public ListForm()
        {
            InitializeComponent();
            int page = 1;
            int count = 5;
            ((PagingPanelElement)(gridCourse.GetChildAt(0).GetChildAt(0).GetChildAt(1))).NumericButtonsCount = 5;
            gridCourse.MasterTemplate.EnableFiltering = true;
            gridCourse.MasterTemplate.EnablePaging = true;
            gridCourse.BestFitColumns(BestFitColumnMode.AllCells);
            gridCourse.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            gridCourse.AutoExpandGroups = true;
            gridCourse.DataSource = SectionService.GetCount().Select(c => new
            {
                c.Name,
                LevelAssigned = c.LevelName,
                Current = c.IsActive ? "Yes" : "No",
                Date = c.CreatedAt.ToShortDateString(),
            });
        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            try
            {
                var newForm = new NewForm { StartPosition = FormStartPosition.CenterScreen };
                ThemeResolutionService.ApplyThemeToControlTree(newForm, ThemeName);
                StartPosition = FormStartPosition.CenterParent;
                newForm.ShowDialog();
            }
            catch (Exception ex)
            {
                _logger.Error("Error Message: " + ex.Message.ToString(), ex);
                throw;
            }
        }

        private void gridCourse_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnEdit.Enabled = true;

                _sectionModel = SectionService.GetCount().ToList()[e.RowIndex];
                canPerformOtherAction = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var newForm = new NewForm { StartPosition = FormStartPosition.CenterScreen, Id = _sectionModel.Id, IsEdit = true};
                ThemeResolutionService.ApplyThemeToControlTree(newForm, ThemeName);
                /*newForm.IsEdit = true;
                newForm.Id = _sectionModel.Id;*/
                newForm.ShowDialog();
            }
            catch (Exception ex)
            {
                _logger.Error("Error Message: " + ex.Message.ToString(), ex);
                throw;
            }
        }
    }
}
