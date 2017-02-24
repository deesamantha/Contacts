using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{

    public class Contact : ListViewItem
    {
        string firstName;
        string lastName;
        string phone;
        string email;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public override string ToString()
        {
            return FirstName + " " + LastName + "\r\n" + Phone + "\r\n" + Email;
        }
    }
}
