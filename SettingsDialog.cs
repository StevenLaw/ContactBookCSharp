using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContactBook
{
    public partial class SettingsDialog : Form
    {
        public SettingsDialog()
        {
            InitializeComponent();

            cbxContactID.Checked = Properties.Settings.Default.ContactIdVisible;
            cbxFirstName.Checked = Properties.Settings.Default.FirstNameVisible;
            cbxLastName.Checked = Properties.Settings.Default.LastNameVisible;
            cbxStreet.Checked = Properties.Settings.Default.StreetVisible;
            cbxCity.Checked = Properties.Settings.Default.CityVisible;
            cbxProvince.Checked = Properties.Settings.Default.ProvinceVisible;
            cbxPostalCode.Checked = Properties.Settings.Default.PostalCodeVisible;
            cbxPhone.Checked = Properties.Settings.Default.PhoneVisible;
            cbxEmail.Checked = Properties.Settings.Default.EmailVisible;
        }

        private void SetVisibility()
        {
            Properties.Settings.Default.ContactIdVisible = cbxContactID.Checked;
            Properties.Settings.Default.FirstNameVisible = cbxFirstName.Checked;
            Properties.Settings.Default.LastNameVisible = cbxLastName.Checked;
            Properties.Settings.Default.StreetVisible = cbxStreet.Checked;
            Properties.Settings.Default.CityVisible = cbxCity.Checked;
            Properties.Settings.Default.ProvinceVisible = cbxProvince.Checked;
            Properties.Settings.Default.PostalCodeVisible = cbxPostalCode.Checked;
            Properties.Settings.Default.PhoneVisible = cbxPhone.Checked;
            Properties.Settings.Default.EmailVisible = cbxEmail.Checked;
            Properties.Settings.Default.Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            SetVisibility();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SetVisibility();
            Close();
        }
    }
}
