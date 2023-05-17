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
                comboBoxType.DataSource = new String[]
                {
                    Enum.GetName(typeof(Types), Types.Airbus),
                    Enum.GetName(typeof(Types), Types.ОАК),
                    Enum.GetName(typeof(Types), Types.Boeing)
                };

                flights = db.Flights.ToList();
                bindingNavigator = new BindingNavigator(true);
                bindingSourceFlights = new BindingSource();
                bindingSourceFlights.DataSource = flights;
                bindingNavigator.BindingSource = bindingSourceFlights;

                var saveButton = bindingNavigator.Items.Add("Save");

                bindingNavigator.Items.Remove(bindingNavigator.AddNewItem);
                bindingNavigator.Items.Remove(bindingNavigator.DeleteItem);
                this.Controls.Add(bindingNavigator);

                MoveItem_Click(null, new EventArgs());
                saveButton.Click += Save_Click;
                bindingNavigator.PositionItem.TextChanged += MoveItem_Click;
                bindingNavigator.MoveNextItem.Click += MoveItem_Click;
                bindingNavigator.MoveFirstItem.Click += MoveItem_Click;
                bindingNavigator.MoveLastItem.Click += MoveItem_Click;
                bindingNavigator.MovePreviousItem.Click += MoveItem_Click;
            }
        }

        private void Save_Click(object? sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (int.TryParse(textBoxId.Text, out var id))
                {
                    var flight = db.Flights.FirstOrDefault(x => x.id_flight == id);
                    if (flight != null)
                    {
                        if (DateTime.TryParse(textBoxTime.Text, out var eta))
                        {
                            flight.eta = eta;
                        }
                        if (int.TryParse(textBoxSum.Text, out var sum))
                        {
                            flight.sum = sum;
                        }
                        if (int.TryParse(textBoxPassCount.Text, out var countPas))
                        {
                            flight.countPas = countPas;
                        }
                        if (int.TryParse(textBoxPassPrice.Text, out var pricePas))
                        {
                            flight.pricePas = pricePas;
                        }
                        if (int.TryParse(textBoxCrewCount.Text, out var countCrew))
                        {
                            flight.countCrew = countCrew;
                        }
                        if (int.TryParse(textBoxCrewPrice.Text, out var priceCrew))
                        {
                            flight.priceCrew = priceCrew;
                        }
                        if (int.TryParse(textBoxPerc.Text, out var procDop))
                        {
                            flight.procDop = procDop;
                        }


                        switch (comboBoxType.SelectedItem)
                        {
                            case ("Airbus"):
                                flight.type = Types.Airbus;
                                break;
                            case ("Boeing"):
                                flight.type = Types.Boeing;
                                break;
                            case ("ОАК"):
                                flight.type = Types.ОАК;
                                break;

                        }
                        
                        

                        db.SaveChanges();
                    }
                }

            }
        }

        private void MoveItem_Click(object? sender, EventArgs e)
        {
            if (int.TryParse(bindingNavigator.PositionItem.Text, out var pos) &&
                pos <= flights.Count && pos >= 0)
            {
                pos -= 1;
                textBoxId.Text = flights[pos].id_flight.ToString();
                textBoxPassCount.Text = flights[pos].countPas.ToString();
                textBoxPassPrice.Text = flights[pos].pricePas.ToString();
                textBoxCrewCount.Text = flights[pos].countCrew.ToString();
                textBoxCrewPrice.Text = flights[pos].priceCrew.ToString();
                textBoxPerc.Text = flights[pos].procDop.ToString();
                textBoxTime.Text = flights[pos].eta.ToString();
                textBoxSum.Text = flights[pos].sum.ToString();

                comboBoxType.SelectedItem = flights[pos].type.ToString();

            }

        }
    }
}
