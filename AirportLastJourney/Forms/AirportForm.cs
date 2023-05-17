using AirportLastJourney.Forms;
using AirportLastJourney.Models;
using System.Globalization;
using _Excel = Microsoft.Office.Interop.Excel;

namespace AirportLastJourney
{
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
        private void UpdateDataGrid(List<Flights> f)
        {

            flights.Clear();
            flights.AddRange(f);
            BinSource.ResetBindings(false);
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
        private void textBoxFromTo_TextChanged(object sender, EventArgs e)
        {
            makeFilter();
        }
        private void textBoxFromTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void checkBox_Click(object sender, EventArgs e)
        {
            makeFilter();
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
                    var result = MessageBox.Show("Вы уверены, что хотите добавить рейс?", "Добавление", MessageBoxButtons.YesNo);
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
                    var result = MessageBox.Show("Вы уверены, что хотите изменить рейс?", "Изменение", MessageBoxButtons.YesNo);
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
            var ExcelApp = new _Excel.Application();
            _Excel.Workbook ExcelWorkBook;
            _Excel.Worksheet ExcelWorkSheet;
            //Книга.^
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (_Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
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
                    if (this.FlightsDGV.Columns[j].Name == "typeColumn")
                    {
                        string stringValue = Enum.GetName(typeof(Types), (int)FlightsDGV.Rows[i].Cells[j].Value);
                        ExcelApp.Cells[i + 2, j + 1] = stringValue;
                    }
                    else
                    {
                        ExcelApp.Cells[i + 2, j + 1] = FlightsDGV.Rows[i].Cells[j].Value;
                    }

                }
            }
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }


        private void AirportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
                    TextBoxFromToFilter(textBoxFrom, textBoxTo);

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
                    TextBoxFromToFilter(textBoxPassFrom, textBoxPassTo);

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
                    TextBoxFromToFilter(textBoxCrewFrom, textBoxCrewTo);

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


        // Фильтрация текстовых полей (принимает поля для реюзабельности кода)
        private void TextBoxFromToFilter(TextBox textFrom, TextBox textTo)
        {
            // Заглушки
            object sender = new object();
            EventArgs e = new EventArgs();

            using (var db = new ApplicationContext())
            {
                if (textFrom.Text.Length != 0 && textTo.Text.Length != 0)
                {
                    double.TryParse(String.Concat(textFrom.Text.Split(",")), out var value);
                    double.TryParse(String.Concat(textTo.Text.Split(",")), out var value2);

                    Console.WriteLine(value.ToString("#,#", CultureInfo.InvariantCulture));
                    textFrom.Text = value.ToString("#,#", CultureInfo.InvariantCulture);
                    textFrom.SelectionStart = textFrom.Text.Length;


                    Console.WriteLine(value2.ToString("#,#", CultureInfo.InvariantCulture));
                    textTo.Text = value2.ToString("#,#", CultureInfo.InvariantCulture);
                    textTo.SelectionStart = textTo.Text.Length;

                    if (value <= value2)
                    {
                        if (textFrom == textBoxFrom)
                        {
                            var temp = flights.Where(x => x.sum >= value && x.sum <= value2).ToList();
                            flights.Clear();
                            flights.AddRange(temp);
                        }
                        else if (textFrom == textBoxPassFrom)
                        {
                            var temp = flights.Where(x => x.countPas >= value && x.countPas <= value2).ToList();
                            flights.Clear();
                            flights.AddRange(temp);
                        }
                        else if (textFrom == textBoxCrewFrom)
                        {
                            var temp = flights.Where(x => x.countCrew >= value && x.countCrew <= value2).ToList();
                            flights.Clear();
                            flights.AddRange(temp);
                        }
                        comboBoxSort_SelectedIndexChanged(sender, e);
                    }
                    else
                    {
                        if (textFrom == textBoxFrom)
                        {
                            var temp = flights.Where(x => x.sum >= value).ToList();
                            flights.Clear();
                            flights.AddRange(temp);
                        }
                        else if (textFrom == textBoxPassFrom)
                        {
                            var temp = flights.Where(x => x.countPas >= value).ToList();
                            flights.Clear();
                            flights.AddRange(temp);
                        }
                        else if (textFrom == textBoxCrewFrom)
                        {
                            var temp = flights.Where(x => x.countCrew >= value).ToList();
                            flights.Clear();
                            flights.AddRange(temp);
                        }
                        comboBoxSort_SelectedIndexChanged(sender, e);
                    }
                }
                else if (textFrom.Text.Length != 0)
                {
                    double.TryParse(String.Concat(textFrom.Text.Split(",")), out var value);
                    Console.WriteLine(value.ToString("#,#", CultureInfo.InvariantCulture));
                    textFrom.Text = value.ToString("#,#", CultureInfo.InvariantCulture);
                    textFrom.SelectionStart = textFrom.Text.Length;

                    if (textFrom == textBoxFrom)
                    {
                        var temp = flights.Where(x => x.sum >= value).ToList();
                        flights.Clear();
                        flights.AddRange(temp);
                    }
                    else if (textFrom == textBoxPassFrom)
                    {
                        var temp = flights.Where(x => x.countPas >= value).ToList();
                        flights.Clear();
                        flights.AddRange(temp);
                    }
                    else if (textFrom == textBoxCrewFrom)
                    {
                        var temp = flights.Where(x => x.countCrew >= value).ToList();
                        flights.Clear();
                        flights.AddRange(temp);
                    }
                    comboBoxSort_SelectedIndexChanged(sender, e);
                }
                else if (textTo.Text.Length != 0)
                {
                    double.TryParse(String.Concat(textTo.Text.Split(",")), out var value);
                    Console.WriteLine(value.ToString("#,#", CultureInfo.InvariantCulture));
                    textTo.Text = value.ToString("#,#", CultureInfo.InvariantCulture);
                    textTo.SelectionStart = textTo.Text.Length;
                    if (value != 0)
                    {
                        if (textFrom == textBoxFrom)
                        {
                            var temp = flights.Where(x => x.sum <= value).ToList();
                            flights.Clear();
                            flights.AddRange(temp);
                        }
                        else if (textFrom == textBoxPassFrom)
                        {
                            var temp = flights.Where(x => x.countPas <= value).ToList();
                            flights.Clear();
                            flights.AddRange(temp);

                        }
                        else if (textFrom == textBoxCrewFrom)
                        {
                            var temp = flights.Where(x => x.countCrew <= value).ToList();
                            flights.Clear();
                            flights.AddRange(temp);

                        }
                    }
                    comboBoxSort_SelectedIndexChanged(sender, e);
                }
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            makeFilter();
        }

        private void FlightsDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.FlightsDGV.Columns[e.ColumnIndex].Name == "Тип самолёта")
            {
                if (e.Value != null)
                {
                    string stringValue = Enum.GetName(typeof(Types), (int)e.Value)!;

                    e.Value = stringValue;

                }
            }
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            AirportListForm airportListForm = new AirportListForm();
            airportListForm.ShowDialog();

        }
    }
}