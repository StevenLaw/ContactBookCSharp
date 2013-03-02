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
    /// <summary>
    /// This is the add contact form
    /// </summary>
    public partial class AddContactForm : Form
    {
        private ContactDBDataContext db;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddContactForm"/> class.
        /// </summary>
        public AddContactForm()
        {
            InitializeComponent();
            db = new ContactDBDataContext();

            List<Province> provinces = db.Provinces.ToList<Province>();
            provinces.Insert(0, new Province { Name = "", ProvinceCode = "" });
            cmbProvince.DisplayMember = "Name";
            cmbProvince.ValueMember = "ProvinceCode";
            cmbProvince.DataSource = provinces;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFName.Text != "" && txtLName.Text != "")
            {
                Contact c = new Contact();

                c.FName = txtFName.Text;
                c.LName = txtLName.Text;
                c.Street = txtStreet.Text;
                c.City = txtCity.Text;
                if (!cmbProvince.SelectedValue.Equals(""))
                    c.Province = cmbProvince.SelectedValue.ToString();
                c.PostalCode = txtPostalCode.Text;
                c.Phone = txtPhone.Text;
                c.Email = txtEmail.Text;

                try
                {
                    db.Contacts.InsertOnSubmit(c);
                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "There was a database error:\n" + ex.Message);
                }

                Close();
            }
            else
            {
                MessageBox.Show(this, "Please enter a value for the first and last names.");
            }
        }
    }
}
