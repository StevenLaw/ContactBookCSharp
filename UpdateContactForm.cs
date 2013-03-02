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
    /// This is the Update Contact form
    /// </summary>
    public partial class UpdateContactForm : Form
    {
        private ContactDBDataContext db;
        private int contactID;
        private Contact newContact;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContactForm"/> class.
        /// </summary>
        /// <param name="contactID">The contact ID.</param>
        public UpdateContactForm(int contactID)
        {
            InitializeComponent();

            db = new ContactDBDataContext();

            List<Province> provinces = db.Provinces.ToList<Province>();
            provinces.Insert(0, new Province { Name = "", ProvinceCode = "" });
            cmbProvince.DisplayMember = "Name";
            cmbProvince.ValueMember = "ProvinceCode";
            cmbProvince.DataSource = provinces;

            this.contactID = contactID;
            //var contact = (from c in db.Contacts
            //           where c.Id == ContactID
            //           select c).Single();
            var contact = db.Contacts.Single(c => c.Id == contactID);

            txtFName.Text = contact.FName;
            txtLName.Text = contact.LName;
            txtStreet.Text = contact.Street;
            txtCity.Text = contact.City;
            if (contact.Province != null)
            {
                cmbProvince.SelectedValue = contact.Province;
            }
            txtPostalCode.Text = contact.PostalCode;
            txtPhone.Text = contact.Phone;
            txtEmail.Text = contact.Email;
        }

        /// <summary>
        /// Returns the changes made to the selected contact.
        /// </summary>
        /// <returns>the changed contact</returns>
        public Contact ReturnChanges()
        {
            return newContact;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFName.Text != "" && txtLName.Text != "")
            {
                //var contact = (from c in db.Contacts
                //               where c.Id == ContactID
                //               select c).Single();
                var contact = db.Contacts.Single(c => c.Id == contactID);

                newContact = new Contact();

                newContact.FName = txtFName.Text;
                newContact.LName = txtLName.Text;
                newContact.Street = txtStreet.Text;
                newContact.City = txtCity.Text;
                if (!cmbProvince.SelectedValue.Equals(""))
                    newContact.Province = cmbProvince.SelectedValue.ToString();
                newContact.PostalCode = txtPostalCode.Text;
                newContact.Phone = txtPhone.Text;
                newContact.Email = txtEmail.Text;

                //contact.FName = txtFName.Text;
                //contact.LName = txtLName.Text;
                //contact.Street = txtStreet.Text;
                //contact.City = txtCity.Text;
                //if (!cmbProvince.SelectedValue.Equals(""))
                //    contact.Province = cmbProvince.SelectedValue.ToString();
                //contact.PostalCode = txtPostalCode.Text;
                //contact.Phone = txtPhone.Text;
                //contact.Email = txtEmail.Text;

                try
                {
                    //db.Contacts.Attach(tmp, contact);
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
