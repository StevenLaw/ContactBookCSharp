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
    /// This is the main form for the program
    /// </summary>
    public partial class ContactBook : Form
    {
        private ContactDBDataContext db;

        /// <summary>
        /// Initilize the form and the data structures
        /// </summary>
        /// <remarks>
        ///   <list type="number">
        ///   <item>
        ///   <description>Initialize the components</description>
        ///   </item>
        ///   <item>
        ///   <description>Initilize the DataContext</description>
        ///   </item>
        ///   <item>
        ///   </item>
        ///   </list>
        /// </remarks>
        public ContactBook()
        {
            InitializeComponent();
            db = new ContactDBDataContext();

            var conQuery = from c in db.Contacts
                           select c;

            dgvTableAlt.DataSource = conQuery;

            List<Province> provinces = db.Provinces.ToList<Province>();
            provinces.Insert(0, new Province { Name = "", ProvinceCode = "" });
            cmbFilter.DisplayMember = "Name";
            cmbFilter.ValueMember = "ProvinceCode";
            cmbFilter.DataSource = provinces;

            UpdateTable();
            dgvTable.ClearSelection();

            SetButtonsEnabled();

            LoadSettings();
        }

        /// <summary>
        /// This method clears the table and reloads it from the database
        /// </summary>
        private void UpdateTable()
        {
            dgvTable.Rows.Clear();

            var contacts = db.Contacts;

            foreach (var contact in contacts)
            {
                // filter out all items that do not have the required province code
                if (cmbFilter.SelectedValue == null || cmbFilter.SelectedValue.ToString() == "" || 
                    contact.Province.ToString() == cmbFilter.SelectedValue.ToString())
                {
                    string province = "";
                    // this prevents a null province from causing problems
                    if (contact.Province != null)
                    {
                        province = (from p in db.Provinces
                                    where p.ProvinceCode == contact.Province
                                    select p.Name).First();

                    }
                    dgvTable.Rows.Add(
                        contact.Id,
                        contact.FName,
                        contact.LName,
                        contact.Street,
                        contact.City,
                        province,
                        contact.PostalCode,
                        contact.Phone,
                        contact.Email);
                }
            }

            // this updates the other table
            var conQuery = from c in db.Contacts
                           select c;

            dgvTableAlt.DataSource = conQuery;
            dgvTableAlt.Refresh();
        }

        /// <summary>
        /// This will set the buttons to be enabled or disabled based on the number of 
        /// items selected.
        /// </summary>
        private void SetButtonsEnabled()
        {
            if (tabControl1.SelectedIndex == 0)
            {
                if (dgvTable.SelectedRows.Count == 1)
                {
                    btnDelete.Enabled = true;
                    deleteToolStripMenuItem.Enabled = true;
                    tsbDeleteMain.Enabled = true;
                    tsbDeleteAlt.Enabled = true;
                    cmsDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                    updateToolStripMenuItem.Enabled = true;
                    tsbUpdateMain.Enabled = true;
                    cmsUpdate.Enabled = true;
                }
                else if (dgvTable.SelectedRows.Count > 1)
                {
                    btnDelete.Enabled = true;
                    deleteToolStripMenuItem.Enabled = true;
                    tsbDeleteMain.Enabled = true;
                    tsbDeleteAlt.Enabled = true;
                    cmsDelete.Enabled = true;
                    btnUpdate.Enabled = false;
                    updateToolStripMenuItem.Enabled = false;
                    tsbUpdateMain.Enabled = false;
                    cmsUpdate.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = false;
                    deleteToolStripMenuItem.Enabled = false;
                    tsbDeleteMain.Enabled = false;
                    tsbDeleteAlt.Enabled = false;
                    cmsDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    updateToolStripMenuItem.Enabled = false;
                    tsbUpdateMain.Enabled = false;
                    cmsUpdate.Enabled = false;
                }
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                if (dgvTableAlt.SelectedRows.Count == 1)
                {
                    btnDelete.Enabled = true;
                    deleteToolStripMenuItem.Enabled = true;
                    tsbDeleteMain.Enabled = true;
                    tsbDeleteAlt.Enabled = true;
                    cmsDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                    updateToolStripMenuItem.Enabled = true;
                    tsbUpdateMain.Enabled = true;
                    cmsUpdate.Enabled = true;
                }
                else if (dgvTableAlt.SelectedRows.Count > 1)
                {
                    btnDelete.Enabled = true;
                    deleteToolStripMenuItem.Enabled = true;
                    tsbDeleteMain.Enabled = true;
                    tsbDeleteAlt.Enabled = true;
                    cmsDelete.Enabled = true;
                    btnUpdate.Enabled = false;
                    updateToolStripMenuItem.Enabled = false;
                    tsbUpdateMain.Enabled = false;
                    cmsUpdate.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = false;
                    deleteToolStripMenuItem.Enabled = false;
                    tsbDeleteMain.Enabled = false;
                    tsbDeleteAlt.Enabled = false;
                    cmsDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    updateToolStripMenuItem.Enabled = false;
                    tsbUpdateMain.Enabled = false;
                    cmsUpdate.Enabled = false;
                }
            }
        }

        private void LoadSettings()
        {
            // Contact Id
            if (Properties.Settings.Default.ContactIdVisible)
            {
                dgvTable.Columns["Id"].Visible = true;
                contactIdToolStripMenuItem.Checked = true;
            }
            else
            {
                dgvTable.Columns["Id"].Visible = false;
                contactIdToolStripMenuItem.Checked = false;
            }
            // First Name
            if (Properties.Settings.Default.FirstNameVisible)
            {
                dgvTable.Columns["FName"].Visible = true;
                firstNameToolStripMenuItem.Checked = true;
            }
            else
            {
                dgvTable.Columns["FName"].Visible = false;
                firstNameToolStripMenuItem.Checked = false;
            }
            // Last Name
            if (Properties.Settings.Default.LastNameVisible)
            {
                dgvTable.Columns["LName"].Visible = true;
                lastNameToolStripMenuItem.Checked = true;
            }
            else
            {
                dgvTable.Columns["LName"].Visible = false;
                lastNameToolStripMenuItem.Checked = false;
            }
            // Street
            if (Properties.Settings.Default.StreetVisible)
            {
                dgvTable.Columns["Street"].Visible = true;
                streetToolStripMenuItem.Checked = true;
            }
            else
            {
                dgvTable.Columns["Street"].Visible = false;
                streetToolStripMenuItem.Checked = false;
            }
            // City
            if (Properties.Settings.Default.CityVisible)
            {
                dgvTable.Columns["City"].Visible = true;
                cityToolStripMenuItem.Checked = true;
            }
            else
            {
                dgvTable.Columns["City"].Visible = false;
                cityToolStripMenuItem.Checked = false;
            }
            // Province
            if (Properties.Settings.Default.ProvinceVisible)
            {
                dgvTable.Columns["Province"].Visible = true;
                provinceToolStripMenuItem.Checked = true;
            }
            else
            {
                dgvTable.Columns["Province"].Visible = false;
                provinceToolStripMenuItem.Checked = false;
            }
            // Postal Code
            if (Properties.Settings.Default.PostalCodeVisible)
            {
                dgvTable.Columns["PostalCode"].Visible = true;
                postalCodeToolStripMenuItem.Checked = true;
            }
            else
            {
                dgvTable.Columns["PostalCode"].Visible = false;
                postalCodeToolStripMenuItem.Checked = false;
            }
            // Phone
            if (Properties.Settings.Default.PhoneVisible)
            {
                dgvTable.Columns["Phone"].Visible = true;
                phoneNumberToolStripMenuItem.Checked = true;
            }
            else
            {
                dgvTable.Columns["Phone"].Visible = false;
                phoneNumberToolStripMenuItem.Checked = false;
            }
            // Email
            if (Properties.Settings.Default.ContactIdVisible)
            {
                dgvTable.Columns["Id"].Visible = true;
                contactIdToolStripMenuItem.Checked = true;
            }
            else
            {
                dgvTable.Columns["Id"].Visible = false;
                contactIdToolStripMenuItem.Checked = false;
            }

        }

        /// <summary>
        /// This event handler closes the program.
        /// </summary>
        /// <param name="sender">The object senting the event</param>
        /// <param name="e">The arguments of the event</param>
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// This simply opens an about menu.
        /// </summary>
        /// <param name="sender">The object senting the event</param>
        /// <param name="e">The arguments of the event</param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();

            about.Show(this);
        }

        /// <summary>
        /// The purpose of this method is to allow multiple controls to add items. It
        /// opens the add menu and then updates the table.
        /// </summary>
        /// <param name="sender">The object senting the event</param>
        /// <param name="e">The arguments of the event</param>
        private void Add_Click(object sender, EventArgs e)
        {
            AddContactForm add = new AddContactForm();
            add.ShowDialog(this);
            UpdateTable();
        }

        /// <summary>
        /// This opens the update menu, retrieves the changed Contact object, updates 
        /// the database, then the table.
        /// </summary>
        /// <remarks>
        /// For some obscure reason I could not get it to update the database in the 
        /// menu class and reflect this on the table when it returned.
        /// </remarks>
        /// <param name="sender">The object senting the event</param>
        /// <param name="e">The arguments of the event</param>
        private void Update_Click(object sender, EventArgs e)
        {
            int contactID = Convert.ToInt32(dgvTable.SelectedRows[0].Cells[0].Value);
            UpdateContactForm update = new UpdateContactForm(contactID);
            update.ShowDialog(this);
            Contact newContact = update.ReturnChanges();
            if (newContact != null)
            {
                // fetch the correct Contact
                var contact = db.Contacts.Single(c => c.Id == contactID);
                // edit it
                contact.FName = newContact.FName;
                contact.LName = newContact.LName;
                contact.Street = newContact.Street;
                contact.City = newContact.City;
                if (newContact.Province != "")
                    contact.Province = newContact.Province;
                contact.PostalCode = newContact.PostalCode;
                contact.Phone = newContact.Phone;
                contact.Email = newContact.Email;
                try
                {
                    // submit changes
                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "There was a database error:\n" + ex.Message);
                }
                UpdateTable();
            }
        }

        /// <summary>
        /// This deletes all of the currently selected 
        /// </summary>
        /// <param name="sender">The object senting the event</param>
        /// <param name="e">The arguments of the event</param>
        private void Delete_Click(object sender, EventArgs e)
        {
            // confirm the deletion and the amount to be deleted
            if (tabControl1.SelectedIndex == 0)
            {
                // delete from main tab
                DialogResult result = MessageBox.Show(this, "Do you want to delete " +
                    dgvTable.SelectedRows.Count + " items?", "Delete?",
                    MessageBoxButtons.OKCancel);
                // if the deletion is accepted
                if (result == DialogResult.OK)
                {

                    List<Contact> selectedContacts = new List<Contact>();
                    // fetch the Contacts to be deleted and add them to a list
                    for (int i = 0; i < dgvTable.SelectedRows.Count; i++)
                    {
                        int id = Convert.ToInt32(dgvTable.SelectedRows[i].Cells[0].Value.ToString());
                        var tmp = (from c in db.Contacts
                                   where c.Id == id
                                   select c).Single();
                        selectedContacts.Add(tmp);
                    }
                    try
                    {
                        // attempt to delete the contacts
                        db.Contacts.DeleteAllOnSubmit(selectedContacts);
                        db.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, "There was a database error:\n" + ex.Message);
                    }
                    // update the table
                    UpdateTable();
                }
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                // delete from alt tab
                DialogResult result = MessageBox.Show(this, "Do you want to delete " +
                    dgvTableAlt.SelectedRows.Count + " items?", "Delete?",
                    MessageBoxButtons.OKCancel);
                // if the deletion is accepted
                if (result == DialogResult.OK)
                {

                    List<Contact> selectedContacts = new List<Contact>();
                    // fetch the Contacts to be deleted and add them to a list
                    for (int i = 0; i < dgvTableAlt.SelectedRows.Count; i++)
                    {
                        int id = Convert.ToInt32(dgvTableAlt.SelectedRows[i].Cells[0].Value.ToString());
                        var tmp = (from c in db.Contacts
                                   where c.Id == id
                                   select c).Single();
                        selectedContacts.Add(tmp);
                    }
                    try
                    {
                        // attempt to delete the contacts
                        db.Contacts.DeleteAllOnSubmit(selectedContacts);
                        db.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, "There was a database error:\n" + ex.Message);
                    }
                    // update the table
                    UpdateTable();
                }
            }
        }

        /// <summary>
        /// Changes the enabled state of the buttons if the selection is changed.
        /// </summary>
        /// <param name="sender">The object senting the event</param>
        /// <param name="e">The arguments of the event</param>
        private void dgvTable_SelectionChanged(object sender, EventArgs e)
        {
            SetButtonsEnabled();
        }

        /// <summary>
        /// Refreshes the table and clears the selection
        /// </summary>
        /// <param name="sender">The object senting the event</param>
        /// <param name="e">The arguments of the event</param>
        private void Refresh_Click(object sender, EventArgs e)
        {
            UpdateTable();
            dgvTable.ClearSelection();
            dgvTableAlt.ClearSelection();
        }

        /// <summary>
        /// Toggles the visibility of the associated column
        /// </summary>
        /// <param name="sender">The object senting the event</param>
        /// <param name="e">The arguments of the event</param>
        private void contactIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTable.Columns["Id"].Visible == true)
                dgvTable.Columns["Id"].Visible = false;
            else
                dgvTable.Columns["Id"].Visible = true;
        }

        /// <summary>
        /// Toggles the visibility of the associated column
        /// </summary>
        /// <param name="sender">The object senting the event</param>
        /// <param name="e">The arguments of the event</param>
        private void firstNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTable.Columns["FName"].Visible == true)
                dgvTable.Columns["FName"].Visible = false;
            else
                dgvTable.Columns["FName"].Visible = true;
        }

        /// <summary>
        /// Toggles the visibility of the associated column
        /// </summary>
        /// <param name="sender">The object senting the event</param>
        /// <param name="e">The arguments of the event</param>
        private void lastNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTable.Columns["LName"].Visible == true)
                dgvTable.Columns["LName"].Visible = false;
            else
                dgvTable.Columns["LName"].Visible = true;
        }

        /// <summary>
        /// Toggles the visibility of the associated column
        /// </summary>
        /// <param name="sender">The object senting the event</param>
        /// <param name="e">The arguments of the event</param>
        private void streetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTable.Columns["Street"].Visible == true)
                dgvTable.Columns["Street"].Visible = false;
            else
                dgvTable.Columns["Street"].Visible = true;
        }

        /// <summary>
        /// Toggles the visibility of the associated column
        /// </summary>
        /// <param name="sender">The object senting the event</param>
        /// <param name="e">The arguments of the event</param>
        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTable.Columns["City"].Visible == true)
                dgvTable.Columns["City"].Visible = false;
            else
                dgvTable.Columns["City"].Visible = true;
        }

        /// <summary>
        /// Toggles the visibility of the associated column
        /// </summary>
        /// <param name="sender">The object senting the event</param>
        /// <param name="e">The arguments of the event</param>
        private void provinceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTable.Columns["Province"].Visible == true)
                dgvTable.Columns["Province"].Visible = false;
            else
                dgvTable.Columns["Province"].Visible = true;
        }

        /// <summary>
        /// Toggles the visibility of the associated column
        /// </summary>
        /// <param name="sender">The object senting the event</param>
        /// <param name="e">The arguments of the event</param>
        private void postalCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTable.Columns["PostalCode"].Visible == true)
                dgvTable.Columns["PostalCode"].Visible = false;
            else
                dgvTable.Columns["PostalCode"].Visible = true;
        }

        /// <summary>
        /// Toggles the visibility of the associated column
        /// </summary>
        /// <param name="sender">The object senting the event</param>
        /// <param name="e">The arguments of the event</param>
        private void phoneNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTable.Columns["Phone"].Visible == true)
                dgvTable.Columns["Phone"].Visible = false;
            else
                dgvTable.Columns["Phone"].Visible = true;
        }

        /// <summary>
        /// Toggles the visibility of the associated column
        /// </summary>
        /// <param name="sender">The object senting the event</param>
        /// <param name="e">The arguments of the event</param>
        private void emailAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTable.Columns["Email"].Visible == true)
                dgvTable.Columns["Email"].Visible = false;
            else
                dgvTable.Columns["Email"].Visible = true;
        }

        /// <summary>
        /// Pointless
        /// </summary>
        /// <param name="sender">The object senting the event</param>
        /// <param name="e">The arguments of the event</param>
        private void toolStripTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                MessageBox.Show("You said " + toolStripTextBox2.Text);
        }

        /// <summary>
        /// Guarantees that the non visible table is not selected.
        /// </summary>
        /// <param name="sender">The object senting the event</param>
        /// <param name="e">The arguments of the event</param>
        
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvTable.ClearSelection();
            dgvTableAlt.ClearSelection();
        }

        /// <summary>
        /// Detect changes in the filter selection
        /// </summary>
        /// <param name="sender">The object senting the event</param>
        /// <param name="e">The arguments of the event</param>
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        /// <summary>
        /// Usefull place to put my own remarks.
        /// </summary>
        /// <param name="sender">The object senting the event</param>
        /// <param name="e">The arguments of the event</param>
        private void btnDataBindRemarks_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In this exercise I found that using a databinding in this situation " +
                "is simply more trouble than it is worth.\n" +
                "At the very least the flexibility is highly limited.\n\n" + 
                "It may be more useful if I am just displaying the data.  The updates work well though.");
        }

        private void settings_Click(object sender, EventArgs e)
        {
            SettingsDialog sd = new SettingsDialog();
            sd.ShowDialog();
            LoadSettings();
        }
    }
}
