using AirportLastJourney.Models;
using ApplicationContext = AirportLastJourney.ApplicationContext;

namespace AirportLastJourney
{
    public partial class AirportForm : Form
    {
        private readonly List<Flights> flights;

        private readonly BindingSource BinSource;
        public AirportForm()
        {
            InitializeComponent();
            FlightsDGV.AutoGenerateColumns = false;
            flights = ReadDb();
            BinSource = new BindingSource();
            BinSource.DataSource = flights;
            FlightsDGV.DataSource = BinSource;
        }

        public List<Flights> ReadDb()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Flights.ToList();
            }
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
                        UpdateDataGrid();
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
                    UpdateDataGrid();
                }
            }
        }
        private void UpdateDataGrid()
        {
            flights.Clear();
            flights.AddRange(ReadDb());
            BinSource.ResetBindings(false);
            InfoStatCal();
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
                        UpdateDataGrid();
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
                        UpdateDataGrid();
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


        private void InfoStatCal()
        {
            CountFlightsTSSL.Text = $"Кол-во рейсов: {flights.Count}";
            CountPasTSSL.Text = $"Всего пассажиров: {flights.Sum(x => x.countPas)}";
            CountCrewTSSL.Text = $"Всего экипажа: {flights.Sum(x => x.countCrew)}";
            SumTSSL.Text = $"Общая сумма: {flights.Sum(x => x.sum)}";
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void expBtn_Click(object sender, EventArgs e)
        {
            //var ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            //Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ////Книга.
            //ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ////Таблица.
            //ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            //ExcelWorkSheet.Columns.ColumnWidth = 24;
            //ExcelApp.Cells[1, 1] = "Номер рейса";
            //ExcelApp.Cells[1, 2] = "Тип самолёта";
            //ExcelApp.Cells[1, 3] = "Время прибытия";
            //ExcelApp.Cells[1, 4] = "Кол-во пассажиров";
            //ExcelApp.Cells[1, 5] = "Сбор за пассажира";
            //ExcelApp.Cells[1, 6] = "Кол-во экипажа";
            //ExcelApp.Cells[1, 7] = "Сбор за экипаж";
            //ExcelApp.Cells[1, 8] = "Процент надбавки";
            //ExcelApp.Cells[1, 9] = "Выручка";
            //for (int i = 0; i < FlightsDGV.Rows.Count; i++)
            //{
            //    for (int j = 0; j < FlightsDGV.ColumnCount; j++)
            //    {
            //        ExcelApp.Cells[i + 2, j + 1] = FlightsDGV.Rows[i].Cells[j].Value;
            //    }
            //}
            //ExcelApp.Visible = true;
            //ExcelApp.UserControl = true;
        }
    }
}
