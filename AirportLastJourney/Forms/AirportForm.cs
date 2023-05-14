using AirportLastJourney.Models;
using System.Globalization;
using System.Windows.Forms;
using ApplicationContext = AirportLastJourney.ApplicationContext;
using Excel = Microsoft.Office.Interop.Excel;

namespace AirportLastJourney
{
    // TODO работа со списком flights и сортировка/фильтрация его, перерисовка на основе этого flights
    public partial class AirportForm : Form
    {
        private readonly List<Flights> flights;

        private readonly BindingSource BinSource;
        public AirportForm(bool isAdmin)
        {
            InitializeComponent();
            using (var db = new ApplicationContext())
            {
                FlightsDGV.AutoGenerateColumns = false;
                flights = db.Flights.ToList();
                BinSource = new BindingSource();
                BinSource.DataSource = flights;
                FlightsDGV.DataSource = BinSource;

                comboBoxType.DataSource = db.Flights.Select(x => x.type).Distinct().ToList();
            }


            if (!isAdmin)
            {
                toolsTS.Visible = false;
                Correction.Visible = false;
                infoSS.Visible = false;
            }



            comboBoxSort.DataSource = new String[]
            {
                "Номеру рейса",
                "Типу самолёта",
                "Времени прибытия",
                "По кол-ву пассажиров",
                "Сбору за пассажира",
                "По кол-ву экипажа",
                "Сбору за экипаж",
                "Проценту надбавки",
                "Выручке"
            };
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнил: Пегушин Григорий ИП-20-3", "Аэропорт",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void AddTool_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var infoForm = new FlightsForm();

                if (infoForm.ShowDialog(this) == DialogResult.OK)
                {
                    var result = MessageBox.Show("Вы уверенны, что хотите добавить рейс?", "Добавление", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        db.Flights.Add(infoForm.Flight);
                        db.SaveChanges();
                        UpdateDataGrid(db.Flights.ToList());
                    }
                }
            }
        }


        private void DeleteTool_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var flight = (Flights)FlightsDGV.Rows[FlightsDGV.SelectedRows[0].Index].DataBoundItem;
                if (MessageBox.Show($"Вы действительно хотите удалить рейс {flight.id_flight}, прилетающий {flight.eta:G}?",
                    "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.Flights.Remove(flight);
                    db.SaveChanges();
                    UpdateDataGrid(db.Flights.ToList());
                }
            }
        }
        private void UpdateDataGrid(List<Flights> f)
        {

            flights.Clear();
            flights.AddRange(f);
            BinSource.ResetBindings(false);
        }

        private void ChangeTool_Click(object sender, EventArgs e)
        {
            // TODO работа с бд
            using (ApplicationContext db = new ApplicationContext())
            {
                var flight = (Flights)FlightsDGV.Rows[FlightsDGV.SelectedRows[0].Index].DataBoundItem;
                flight = db.Flights.FirstOrDefault(x => x.id_flight == flight.id_flight)!;
                var infoForm = new FlightsForm(flight);
                if (infoForm.ShowDialog(this) == DialogResult.OK)
                {
                    var result = MessageBox.Show("Вы уверенны, что хотите изменить рейс?", "Изменение", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        flight.eta = infoForm.Flight.eta;
                        flight.sum = infoForm.Flight.sum;
                        flight.procDop = infoForm.Flight.procDop;
                        flight.pricePas = infoForm.Flight.pricePas;
                        flight.countPas = infoForm.Flight.countPas;
                        flight.countCrew = infoForm.Flight.countCrew;
                        flight.priceCrew = infoForm.Flight.priceCrew;
                        flight.type = infoForm.Flight.type;
                        db.SaveChanges();
                        UpdateDataGrid(db.Flights.ToList());
                    }
                }
                else
                {
                    var result = MessageBox.Show("Может всё-таки изменим?)))", "Изменение", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        flight.eta = infoForm.Flight.eta;
                        flight.sum = infoForm.Flight.sum;
                        flight.procDop = infoForm.Flight.procDop;
                        flight.pricePas = infoForm.Flight.pricePas;
                        flight.countPas = infoForm.Flight.countPas;
                        flight.countCrew = infoForm.Flight.countCrew;
                        flight.priceCrew = infoForm.Flight.priceCrew;
                        flight.type = infoForm.Flight.type;
                        db.SaveChanges();
                        UpdateDataGrid(db.Flights.ToList());
                    }
                }


            }
        }


        private void FlightsDGV_SelectionChanged(object sender, EventArgs e)
        {
            DeliteMenu.Enabled =
            ChangeMenu.Enabled =
            DeliteTool.Enabled =
            ChangeTool.Enabled =
            FlightsDGV.SelectedRows.Count > 0;
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void expBtn_Click(object sender, EventArgs e)
        {
            var ExcelApp = new Excel.Application();
            Excel.Workbook ExcelWorkBook;
            Excel.Worksheet ExcelWorkSheet;
            //Книга.^
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            ExcelWorkSheet.Columns.ColumnWidth = 24;
            ExcelApp.Cells[1, 1] = "Номер рейса";
            ExcelApp.Cells[1, 2] = "Тип самолёта";
            ExcelApp.Cells[1, 3] = "Время прибытия";
            ExcelApp.Cells[1, 4] = "Кол-во пассажиров";
            ExcelApp.Cells[1, 5] = "Сбор за пассажира";
            ExcelApp.Cells[1, 6] = "Кол-во экипажа";
            ExcelApp.Cells[1, 7] = "Сбор за экипаж";
            ExcelApp.Cells[1, 8] = "Процент надбавки";
            ExcelApp.Cells[1, 9] = "Выручка";
            for (int i = 0; i < FlightsDGV.Rows.Count; i++)
            {
                for (int j = 0; j < FlightsDGV.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = FlightsDGV.Rows[i].Cells[j].Value;
                }
            }
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }


        private void AirportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSort.SelectedItem)
            {
                case "Номеру рейса":
                    SortByArg(flights.OrderBy(x => x.id_flight).ToList());
                    break;
                case "Типу самолёта":
                    SortByArg(flights.OrderBy(x => x.type).ToList());
                    break;
                case "Времени прибытия":
                    SortByArg(flights.OrderBy(x => x.eta).ToList());
                    break;
                case "По кол-ву пассажиров":
                    SortByArg(flights.OrderBy(x => x.countPas).ToList());
                    break;
                case "Сбору за пассажира":
                    SortByArg(flights.OrderBy(x => x.pricePas).ToList());
                    break;
                case "По кол-ву экипажа":
                    SortByArg(flights.OrderBy(x => x.countCrew).ToList());
                    break;
                case "Сбору за экипаж":
                    SortByArg(flights.OrderBy(x => x.priceCrew).ToList());
                    break;
                case "Проценту надбавки":
                    SortByArg(flights.OrderBy(x => x.procDop).ToList());
                    break;
                case "Выручке":
                    SortByArg(flights.OrderBy(x => x.sum).ToList());
                    break;
                default: break;
            }
        }

        private void SortByArg(List<Flights> flightList)
        {
            if (radioButtonUpTo.Checked)
            {
                UpdateDataGrid(flightList);
            }
            else if (radioButtonDownTo.Checked)
            {
                flightList.Reverse();
                UpdateDataGrid(flightList);
            }
        }

        private void radioButton_Click(object sender, EventArgs e)
        {
            comboBoxSort_SelectedIndexChanged(sender, e);
        }

        private void FlightsDGV_Paint(object sender, PaintEventArgs e)
        {
            CountFlightsTSSL.Text = $"Кол-во рейсов: {flights.Count}";
            CountPasTSSL.Text = $"Всего пассажиров: {flights.Sum(x => x.countPas)}";
            CountCrewTSSL.Text = $"Всего экипажа: {flights.Sum(x => x.countCrew)}";
            SumTSSL.Text = $"Общая сумма: {flights.Sum(x => x.sum)}";
        }
        private void makeFilter()
        {
            using (var db = new ApplicationContext())
            {
                SortByArg(db.Flights.ToList());

                // Фильтрация по выручке
                if (checkBoxSum.Checked)
                {
                    FromToFilter();

                    textBoxFrom.Enabled = true;
                    textBoxTo.Enabled = true;
                }
                else
                {
                    textBoxFrom.Enabled = false;
                    textBoxTo.Enabled = false;
                }

                // Фильтрация по типу
                if (checkBoxType.Checked)
                {
                    comboBoxType.Enabled = true;

                    var userType = (Types)comboBoxType.SelectedItem;
                    UpdateDataGrid(flights.Where(x => x.type == userType).ToList());
                }
                else
                {
                    comboBoxType.Enabled = false;
                }

                // Фильтрация по кол-ву пассажиров
                if (checkBoxPassCount.Checked)
                {
                    PassangerFilter();

                    textBoxPassFrom.Enabled = true;
                    textBoxPassTo.Enabled = true;
                }
                else
                {
                    textBoxPassFrom.Enabled = false;
                    textBoxPassTo.Enabled = false;
                }

                // Фильтрация по кол-ву экипажа
                if (checkBoxCrewCount.Checked)
                {
                    textBoxCrewFrom.Enabled = true;
                    textBoxCrewTo.Enabled = true;
                }
                else
                {
                    textBoxCrewFrom.Enabled = false;
                    textBoxCrewTo.Enabled = false;
                }

            }
        }
        private void checkBox_Click(object sender, EventArgs e)
        {
            makeFilter();
        }

        private void FromToFilter()
        {
            object sender = new object();
            EventArgs e = new EventArgs();
            using (var db = new ApplicationContext())
            {
                if (textBoxFrom.Text.Length != 0 && textBoxTo.Text.Length != 0)
                {
                    double.TryParse(String.Concat(textBoxFrom.Text.Split(",")), out var value);
                    double.TryParse(String.Concat(textBoxTo.Text.Split(",")), out var value2);

                    Console.WriteLine(value.ToString("#,#", CultureInfo.InvariantCulture));
                    textBoxFrom.Text = value.ToString("#,#", CultureInfo.InvariantCulture);
                    textBoxFrom.SelectionStart = textBoxFrom.Text.Length;


                    Console.WriteLine(value2.ToString("#,#", CultureInfo.InvariantCulture));
                    textBoxTo.Text = value2.ToString("#,#", CultureInfo.InvariantCulture);
                    textBoxTo.SelectionStart = textBoxTo.Text.Length;

                    if (value <= value2)
                    {
                        var temp = flights.Where(x => x.sum >= value && x.sum <= value2).ToList();
                        flights.Clear();
                        flights.AddRange(temp);
                        comboBoxSort_SelectedIndexChanged(sender, e);
                    }
                    else
                    {
                        var temp = flights.Where(x => x.sum >= value).ToList();
                        flights.Clear();
                        flights.AddRange(temp);
                        comboBoxSort_SelectedIndexChanged(sender, e);
                    }
                }
                else if (textBoxFrom.Text.Length != 0)
                {
                    double.TryParse(String.Concat(textBoxFrom.Text.Split(",")), out var value);
                    Console.WriteLine(value.ToString("#,#", CultureInfo.InvariantCulture));
                    textBoxFrom.Text = value.ToString("#,#", CultureInfo.InvariantCulture);
                    textBoxFrom.SelectionStart = textBoxFrom.Text.Length;

                    var temp = flights.Where(x => x.sum >= value).ToList();
                    flights.Clear();
                    flights.AddRange(temp);
                    comboBoxSort_SelectedIndexChanged(sender, e);
                }
                else if (textBoxTo.Text.Length != 0)
                {
                    double.TryParse(String.Concat(textBoxTo.Text.Split(",")), out var value);
                    Console.WriteLine(value.ToString("#,#", CultureInfo.InvariantCulture));
                    textBoxTo.Text = value.ToString("#,#", CultureInfo.InvariantCulture);
                    textBoxTo.SelectionStart = textBoxTo.Text.Length;

                    var temp = flights.Where(x => x.sum <= value).ToList();
                    flights.Clear();
                    flights.AddRange(temp);
                    comboBoxSort_SelectedIndexChanged(sender, e);
                }
            }
        }

        private void PassangerFilter()
        {
            object sender = new object();
            EventArgs e = new EventArgs();
            using (var db = new ApplicationContext())
            {
                if (textBoxPassFrom.Text.Length != 0 && textBoxPassTo.Text.Length != 0)
                {
                    double.TryParse(String.Concat(textBoxPassFrom.Text.Split(",")), out var value);
                    double.TryParse(String.Concat(textBoxPassTo.Text.Split(",")), out var value2);

                    Console.WriteLine(value.ToString("#,#", CultureInfo.InvariantCulture));
                    textBoxPassFrom.Text = value.ToString("#,#", CultureInfo.InvariantCulture);
                    textBoxPassFrom.SelectionStart = textBoxPassFrom.Text.Length;


                    Console.WriteLine(value2.ToString("#,#", CultureInfo.InvariantCulture));
                    textBoxPassTo.Text = value2.ToString("#,#", CultureInfo.InvariantCulture);
                    textBoxPassTo.SelectionStart = textBoxPassTo.Text.Length;

                    if (value <= value2)
                    {
                        var temp = flights.Where(x => x.countPas >= value && x.countPas <= value2).ToList();
                        flights.Clear();
                        flights.AddRange(temp);
                        comboBoxSort_SelectedIndexChanged(sender, e);
                    }
                    else
                    {
                        var temp = flights.Where(x => x.countPas >= value).ToList();
                        flights.Clear();
                        flights.AddRange(temp);
                        comboBoxSort_SelectedIndexChanged(sender, e);
                    }
                }
                else if (textBoxPassFrom.Text.Length != 0)
                {
                    double.TryParse(String.Concat(textBoxPassFrom.Text.Split(",")), out var value);
                    Console.WriteLine(value.ToString("#,#", CultureInfo.InvariantCulture));
                    textBoxPassFrom.Text = value.ToString("#,#", CultureInfo.InvariantCulture);
                    textBoxPassFrom.SelectionStart = textBoxPassFrom.Text.Length;

                    var temp = flights.Where(x => x.countPas >= value).ToList();
                    flights.Clear();
                    flights.AddRange(temp);
                    comboBoxSort_SelectedIndexChanged(sender, e);
                }
                else if (textBoxPassTo.Text.Length != 0)
                {
                    double.TryParse(String.Concat(textBoxPassTo.Text.Split(",")), out var value);
                    Console.WriteLine(value.ToString("#,#", CultureInfo.InvariantCulture));
                    textBoxPassTo.Text = value.ToString("#,#", CultureInfo.InvariantCulture);
                    textBoxPassTo.SelectionStart = textBoxPassTo.Text.Length;

                    var temp = flights.Where(x => x.countPas <= value).ToList();
                    flights.Clear();
                    flights.AddRange(temp);
                    comboBoxSort_SelectedIndexChanged(sender, e);
                }
            }
        }

        private void textBoxFromTo_TextChanged(object sender, EventArgs e)
        {
            makeFilter();
        }
        private void textBoxFromTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            makeFilter();
        }
    }
}
