using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirportLastJourney;
using AirportLastJourney.Models;
using ApplicationContext = AirportLastJourney.ApplicationContext;

namespace AirportLastJourney.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {

                var userAdmin = new User
                {
                    login = "admin",
                    password = "root",
                    isAdmin = true,
                };
                var user = new User
                {
                    login = "user",
                    password = "user",
                    isAdmin = false,
                };

                if (db.Users.OrderBy(x => x.id_user).FirstOrDefault() == null)
                {
                    db.Users.AddRange(userAdmin, user);
                    db.SaveChanges();
                }


                if (db.Users.FirstOrDefault(x => x.login == LoginTextBox.Text && x.password == PasswordTextBox.Text) != null)
                {

                    AirportForm af = new AirportForm();
                    af.Owner = this;
                    Hide();
                    af.Show();
                }
                else
                {
                    MessageBox.Show("Ебалай", "Да");
                };
            }
        }
    }
}
