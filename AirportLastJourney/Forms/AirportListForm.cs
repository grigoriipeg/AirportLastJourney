using AirportLastJourney.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportLastJourney.Forms
{
    public partial class AirportListForm : Form
    {
        private readonly List<Flights> flights;
        private readonly BindingSource bindingSourceFlights;
        BindingNavigator bindingNavigator;
        public AirportListForm()
        {
            InitializeComponent();
            using (ApplicationContext db = new ApplicationContext())
            {
                flights = db.Flights.ToList();
                bindingNavigator = new BindingNavigator(true);
                bindingSourceFlights = new BindingSource();
                bindingSourceFlights.DataSource = flights;
                bindingNavigator.BindingSource = bindingSourceFlights;
                this.Controls.Add(bindingNavigator);

                MoveItem_Click(null, new EventArgs());
                bindingNavigator.MoveNextItem.Click += MoveItem_Click;
                bindingNavigator.MoveFirstItem.Click += MoveItem_Click;
                bindingNavigator.MoveLastItem.Click += MoveItem_Click;
                bindingNavigator.MovePreviousItem.Click += MoveItem_Click;
            }
        }

        private void MoveItem_Click(object? sender, EventArgs e)
        {
            int.TryParse(bindingNavigator.PositionItem.Text, out var pos);
            textBoxId.Text = flights[pos - 1].id_flight.ToString();
            textBoxType.Text = flights[pos - 1].type.ToString();
            textBoxPassCount.Text = flights[pos - 1].countPas.ToString();
            textBoxPassPrice.Text = flights[pos - 1].pricePas.ToString();
            textBoxCrewCount.Text = flights[pos - 1].countCrew.ToString();
            textBoxCrewPrice.Text = flights[pos - 1].priceCrew.ToString();
            textBoxPerc.Text = flights[pos - 1].procDop.ToString();
            textBoxTime.Text = flights[pos - 1].eta.ToString();
            textBoxSum.Text = flights[pos - 1].sum.ToString();
        }
    }
}
