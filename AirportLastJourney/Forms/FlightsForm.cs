using AirportLastJourney.Models;
using ApplicationContext = AirportLastJourney.ApplicationContext;

namespace AirportLastJourney
{
    public partial class FlightsForm : Form
    {
        private readonly Flights flight;
        public string text = "Боинг";

        public FlightsForm()
        {
            InitializeComponent();
            FillDirection();
            
            using (ApplicationContext db = new ApplicationContext())
            {
                var last = db.Flights.OrderBy(x => x.id_flight).LastOrDefault();
                if (last != null)
                {
                    numericFlight.Text = (last.id_flight + 1).ToString();
                }

                flight = new Flights
                {
                    type = Types.Boeing,
                    eta = DateTime.Now,
                    countPas = (int)numericCountPas.Value,
                    pricePas = (double)numericPricePas.Value,
                    countCrew = (int)numericCountCrew.Value,
                    priceCrew = (double)numericPriceCrew.Value,
                    procDop = (double)numericProcDop.Value,
                    sum = 7200
                };
                comboType.SelectedItem = flight.type;
            }

            dateTimeETA.MinDate = DateTime.Now;

            this.Text = "Добавление рейса";
            
        }

        public FlightsForm(Flights source):this()
        {
            this.Text = "Редактирование рейса";
            numericFlight.Text = source.id_flight.ToString();
            comboType.SelectedItem = source.type;
            dateTimeETA.Value = source.eta;
            numericCountPas.Value = source.countPas;
            numericCountCrew.Value = source.countCrew;
            numericPricePas.Value = (decimal)source.pricePas;
            numericPriceCrew.Value = (decimal)source.priceCrew;
            numericProcDop.Value = (decimal)source.procDop;
            textSum.Text = source.sum.ToString();
        }
        public Flights Flight => flight;

        private void FillDirection()
        {
            foreach(Types type in Enum.GetValues(typeof(Types)))
            {
                comboType.Items.Add(type);
            }
        }

        private void comboType_DrawItem(object sender, DrawItemEventArgs e)
        {
            var parent = sender as ComboBox;
            if(parent != null)
            {
                e.DrawBackground();
                Brush brush = new SolidBrush(parent.ForeColor);
                if((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    brush = SystemBrushes.HighlightText;
                }
                if(e.Index >= 0)
                {
                    if (parent.Items[e.Index] is Types type)
                    {
                        text = type.ToString();
                        e.Graphics.DrawString(
                            text,
                            parent.Font,
                            brush,
                            e.Bounds);
                    }
                    else
                    {
                    e.Graphics.DrawString(
                            parent.Items[e.Index].ToString(),
                            parent.Font,
                            brush,
                            e.Bounds);
                    }
                }
                
            }
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboType.SelectedIndex >= 0)
            {
                flight.type = (Types)comboType.SelectedItem;
            }
        }


        private void dateTimeETA_ValueChanged(object sender, EventArgs e)
        {
            flight.eta = dateTimeETA.Value;
        }

        private void numericCountPas_ValueChanged(object sender, EventArgs e)
        {
            flight.countPas = (int)numericCountPas.Value;
            textSum.Text = ((flight.countPas * flight.pricePas + flight.countCrew * flight.priceCrew) *
                (1 + flight.procDop * 0.01)).ToString();
        }

        private void numericPricePas_ValueChanged(object sender, EventArgs e)
        {
            flight.pricePas = (double)numericPricePas.Value;
            textSum.Text = ((flight.countPas * flight.pricePas + flight.countCrew * flight.priceCrew) *
                (1 + flight.procDop * 0.01)).ToString();
        }

        private void numericCountCrew_ValueChanged(object sender, EventArgs e)
        {
            flight.countCrew = (int)numericCountCrew.Value;
            textSum.Text = ((flight.countPas * flight.pricePas + flight.countCrew * flight.priceCrew) *
                (1 + flight.procDop * 0.01)).ToString();
        }

        private void numericPriceCrew_ValueChanged(object sender, EventArgs e)
        {
            flight.priceCrew = (double)numericPriceCrew.Value;
            textSum.Text = ((flight.countPas * flight.pricePas + flight.countCrew * flight.priceCrew) *
                (1 + flight.procDop * 0.01)).ToString();
        }
        private void numericProcDop_ValueChanged(object sender, EventArgs e)
        {
            flight.procDop = (int)numericProcDop.Value;
            textSum.Text = ((flight.countPas * flight.pricePas + flight.countCrew * flight.priceCrew) *
                (1 + flight.procDop * 0.01)).ToString();
        }

        private void textSum_TextChanged(object sender, EventArgs e)
        {
            flight.sum = double.Parse(textSum.Text);
        }
    }
}
