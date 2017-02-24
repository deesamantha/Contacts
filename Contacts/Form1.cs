using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class Form1 : Form
    {
        List<Contact> contacts = new List<Contact>();
        Contact loaded = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (contacts.Count == 0)
            {

                tbEmail.ReadOnly = tbFirstName.ReadOnly = tbLastName.ReadOnly = tbPhone.ReadOnly = false;
                tbPhone.BackColor = tbFirstName.BackColor = tbLastName.BackColor = tbEmail.BackColor = Color.White;
            }
            else
            {
                Edit((Contact)listView1.Items[0]);
            }
        }

        public void Re()
        {
            listView1.Refresh();
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            if (loaded != null)
            {
                loaded.FirstName = tbFirstName.Text;
                loaded.LastName = tbLastName.Text;
                loaded.Phone = tbPhone.Text;
                loaded.Email = tbEmail.Text;

                listView1.Items[loaded.Index] = loaded;
            }
            else
            {
                Contact contact = new Contact();
                contact.ImageIndex = 0;
                contact.FirstName = tbFirstName.Text;
                contact.LastName = tbLastName.Text;
                contact.Email = tbEmail.Text;
                contact.Phone = tbPhone.Text;

                listView1.Items.Add(contact);
                //listView1.Items.Add(contact.ToString(), contact.ImageIndex);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView sentFrom = (ListView)sender;

            Contact contact = new Contact();
            if (sentFrom.SelectedItems.Count > 0)
                contact = (Contact)sentFrom.SelectedItems[0];

            Edit(contact);

        }

        public void Edit(Contact contact)
        {

            tbEmail.Text = contact.Email;
            tbFirstName.Text = contact.FirstName;
            tbLastName.Text = contact.LastName;
            tbPhone.Text = contact.Phone;

            loaded = contact;

            pbEdit.Visible = true;
        }

        private void pbEdit_Click(object sender, EventArgs e)
        {
            listView1.Items[loaded.Index].Remove();
        }

    }
}
