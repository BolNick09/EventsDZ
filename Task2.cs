using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDZ
{
    public class EnterName
    {
        public event EventHandler<BannedUsersEventArgs> ev_BannedUser;
        public void User()
        {
            Console.WriteLine("Enter your name");
            string user = Console.ReadLine();
            if ((user == "Jack" || user == "Steven" || user == "Matew") && ev_BannedUser != null)
            {
                ev_BannedUser(this, new BannedUsersEventArgs(user));
            }
            else
                Console.WriteLine("Welcome to " + user);

        }
    }
    public class BannedUsersEventArgs : EventArgs
    {
        public string Name { get; set; }
        public BannedUsersEventArgs(string s)
        {
            Name = s;
        }
    }
}
