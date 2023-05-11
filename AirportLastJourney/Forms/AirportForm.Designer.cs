namespace AirportLastJourney
{
    partial class AirportForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirportForm));
            this.mainMenuMS = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Correction = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DeliteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsTS = new System.Windows.Forms.ToolStrip();
            this.AddTool = new System.Windows.Forms.ToolStripButton();
            this.ChangeTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DeliteTool = new System.Windows.Forms.ToolStripButton();
            this.FlightsDGV = new System.Windows.Forms.DataGridView();
            this.numFlightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countPasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price4PasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countCrewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price4CrewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procDopColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoSS = new System.Windows.Forms.StatusStrip();
            this.CountFlightsTSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.CountPasTSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.CountCrewTSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.SumTSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb9 = new System.Windows.Forms.RadioButton();
            this.rb8 = new System.Windows.Forms.RadioButton();
            this.rb7 = new System.Windows.Forms.RadioButton();
            this.rb6 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.sortBtn = new System.Windows.Forms.Button();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.filter_txt = new System.Windows.Forms.TextBox();
            this.more_radio = new System.Windows.Forms.RadioButton();
            this.less_radio = new System.Windows.Forms.RadioButton();
            this.expBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mainMenuMS.SuspendLayout();
            this.toolsTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlightsDGV)).BeginInit();
            this.infoSS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuMS
            // 
            this.mainMenuMS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Correction,
            this.About,
            this.выходToolStripMenuItem});
            this.mainMenuMS.Location = new System.Drawing.Point(0, 0);
            this.mainMenuMS.Name = "mainMenuMS";
            this.mainMenuMS.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.mainMenuMS.Size = new System.Drawing.Size(1835, 30);
            this.mainMenuMS.TabIndex = 0;
            this.mainMenuMS.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.экспортToolStripMenuItem});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(59, 24);
            this.File.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // экспортToolStripMenuItem
            // 
            this.экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            this.экспортToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.экспортToolStripMenuItem.Text = "Экспорт";
            // 
            // Correction
            // 
            this.Correction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMenu,
            this.ChangeMenu,
            this.toolStripSeparator1,
            this.DeliteMenu});
            this.Correction.Name = "Correction";
            this.Correction.Size = new System.Drawing.Size(74, 24);
            this.Correction.Text = "Правка";
            // 
            // AddMenu
            // 
            this.AddMenu.Name = "AddMenu";
            this.AddMenu.Size = new System.Drawing.Size(161, 26);
            this.AddMenu.Text = "Добавить";
            // 
            // ChangeMenu
            // 
            this.ChangeMenu.Enabled = false;
            this.ChangeMenu.Name = "ChangeMenu";
            this.ChangeMenu.Size = new System.Drawing.Size(161, 26);
            this.ChangeMenu.Text = "Изменить";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // DeliteMenu
            // 
            this.DeliteMenu.Enabled = false;
            this.DeliteMenu.Name = "DeliteMenu";
            this.DeliteMenu.Size = new System.Drawing.Size(161, 26);
            this.DeliteMenu.Text = "Удалить";
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(118, 24);
            this.About.Text = "О программе";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // toolsTS
            // 
            this.toolsTS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolsTS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTool,
            this.ChangeTool,
            this.toolStripSeparator2,
            this.DeliteTool});
            this.toolsTS.Location = new System.Drawing.Point(0, 30);
            this.toolsTS.Name = "toolsTS";
            this.toolsTS.Size = new System.Drawing.Size(1835, 27);
            this.toolsTS.TabIndex = 1;
            this.toolsTS.Text = "toolStrip1";
            // 
            // AddTool
            // 
            this.AddTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddTool.Name = "AddTool";
            this.AddTool.Size = new System.Drawing.Size(80, 24);
            this.AddTool.Text = "Добавить";
            this.AddTool.Click += new System.EventHandler(this.AddTool_Click);
            // 
            // ChangeTool
            // 
            this.ChangeTool.Enabled = false;
            this.ChangeTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChangeTool.Name = "ChangeTool";
            this.ChangeTool.Size = new System.Drawing.Size(82, 24);
            this.ChangeTool.Text = "Изменить";
            this.ChangeTool.Click += new System.EventHandler(this.ChangeTool_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // DeliteTool
            // 
            this.DeliteTool.Enabled = false;
            this.DeliteTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeliteTool.Name = "DeliteTool";
            this.DeliteTool.Size = new System.Drawing.Size(69, 24);
            this.DeliteTool.Text = "Удалить";
            this.DeliteTool.Click += new System.EventHandler(this.DeleteTool_Click);
            // 
            // FlightsDGV
            // 
            this.FlightsDGV.AllowUserToAddRows = false;
            this.FlightsDGV.AllowUserToDeleteRows = false;
            this.FlightsDGV.AllowUserToResizeColumns = false;
            this.FlightsDGV.AllowUserToResizeRows = false;
            this.FlightsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlightsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numFlightColumn,
            this.typeColumn,
            this.etaColumn,
            this.countPasColumn,
            this.price4PasColumn,
            this.countCrewColumn,
            this.price4CrewColumn,
            this.procDopColumn,
            this.sumColumn});
            this.FlightsDGV.Location = new System.Drawing.Point(0, 76);
            this.FlightsDGV.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.FlightsDGV.MultiSelect = false;
            this.FlightsDGV.Name = "FlightsDGV";
            this.FlightsDGV.ReadOnly = true;
            this.FlightsDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle9.NullValue = "fgn";
            this.FlightsDGV.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.FlightsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FlightsDGV.Size = new System.Drawing.Size(1174, 701);
            this.FlightsDGV.TabIndex = 2;
            this.FlightsDGV.SelectionChanged += new System.EventHandler(this.FlightsDGV_SelectionChanged);
            // 
            // numFlightColumn
            // 
            this.numFlightColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numFlightColumn.DataPropertyName = "id_flight";
            dataGridViewCellStyle1.Format = "####";
            dataGridViewCellStyle1.NullValue = null;
            this.numFlightColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.numFlightColumn.HeaderText = "Номер рейса";
            this.numFlightColumn.MinimumWidth = 6;
            this.numFlightColumn.Name = "numFlightColumn";
            this.numFlightColumn.ReadOnly = true;
            // 
            // typeColumn
            // 
            this.typeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeColumn.DataPropertyName = "Type";
            this.typeColumn.HeaderText = "Тип самолёта";
            this.typeColumn.MinimumWidth = 6;
            this.typeColumn.Name = "typeColumn";
            this.typeColumn.ReadOnly = true;
            // 
            // etaColumn
            // 
            this.etaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.etaColumn.DataPropertyName = "ETA";
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            this.etaColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.etaColumn.HeaderText = "Время прибытия";
            this.etaColumn.MinimumWidth = 6;
            this.etaColumn.Name = "etaColumn";
            this.etaColumn.ReadOnly = true;
            // 
            // countPasColumn
            // 
            this.countPasColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.countPasColumn.DataPropertyName = "CountPas";
            dataGridViewCellStyle3.Format = "N0";
            this.countPasColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.countPasColumn.HeaderText = "Кол-во пассажиров";
            this.countPasColumn.MinimumWidth = 6;
            this.countPasColumn.Name = "countPasColumn";
            this.countPasColumn.ReadOnly = true;
            // 
            // price4PasColumn
            // 
            this.price4PasColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price4PasColumn.DataPropertyName = "PricePas";
            dataGridViewCellStyle4.Format = "C2";
            this.price4PasColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.price4PasColumn.HeaderText = "Сбор на пассажира";
            this.price4PasColumn.MinimumWidth = 6;
            this.price4PasColumn.Name = "price4PasColumn";
            this.price4PasColumn.ReadOnly = true;
            // 
            // countCrewColumn
            // 
            this.countCrewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.countCrewColumn.DataPropertyName = "CountCrew";
            dataGridViewCellStyle5.Format = "N0";
            this.countCrewColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.countCrewColumn.HeaderText = "Кол-во экипажа";
            this.countCrewColumn.MinimumWidth = 6;
            this.countCrewColumn.Name = "countCrewColumn";
            this.countCrewColumn.ReadOnly = true;
            // 
            // price4CrewColumn
            // 
            this.price4CrewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price4CrewColumn.DataPropertyName = "PriceCrew";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.price4CrewColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.price4CrewColumn.HeaderText = "Сбор на экипаж";
            this.price4CrewColumn.MinimumWidth = 6;
            this.price4CrewColumn.Name = "price4CrewColumn";
            this.price4CrewColumn.ReadOnly = true;
            // 
            // procDopColumn
            // 
            this.procDopColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.procDopColumn.DataPropertyName = "ProcDop";
            dataGridViewCellStyle7.Format = "N2";
            this.procDopColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.procDopColumn.HeaderText = "Процент надбавки";
            this.procDopColumn.MinimumWidth = 6;
            this.procDopColumn.Name = "procDopColumn";
            this.procDopColumn.ReadOnly = true;
            // 
            // sumColumn
            // 
            this.sumColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sumColumn.DataPropertyName = "Sum";
            dataGridViewCellStyle8.Format = "C2";
            this.sumColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.sumColumn.HeaderText = "Выручка";
            this.sumColumn.MinimumWidth = 6;
            this.sumColumn.Name = "sumColumn";
            this.sumColumn.ReadOnly = true;
            // 
            // infoSS
            // 
            this.infoSS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.infoSS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CountFlightsTSSL,
            this.CountPasTSSL,
            this.CountCrewTSSL,
            this.SumTSSL});
            this.infoSS.Location = new System.Drawing.Point(0, 785);
            this.infoSS.Name = "infoSS";
            this.infoSS.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.infoSS.Size = new System.Drawing.Size(1835, 26);
            this.infoSS.TabIndex = 3;
            this.infoSS.Text = "statusStrip1";
            // 
            // CountFlightsTSSL
            // 
            this.CountFlightsTSSL.Name = "CountFlightsTSSL";
            this.CountFlightsTSSL.Size = new System.Drawing.Size(124, 20);
            this.CountFlightsTSSL.Text = "Кол-во рейсов 0";
            // 
            // CountPasTSSL
            // 
            this.CountPasTSSL.Name = "CountPasTSSL";
            this.CountPasTSSL.Size = new System.Drawing.Size(149, 20);
            this.CountPasTSSL.Text = "Всего пассажиров 0";
            // 
            // CountCrewTSSL
            // 
            this.CountCrewTSSL.Name = "CountCrewTSSL";
            this.CountCrewTSSL.Size = new System.Drawing.Size(123, 20);
            this.CountCrewTSSL.Text = "Всего экипажа 0";
            // 
            // SumTSSL
            // 
            this.SumTSSL.Name = "SumTSSL";
            this.SumTSSL.Size = new System.Drawing.Size(131, 20);
            this.SumTSSL.Text = "Общая выручка 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb9);
            this.groupBox1.Controls.Add(this.rb8);
            this.groupBox1.Controls.Add(this.rb7);
            this.groupBox1.Controls.Add(this.rb6);
            this.groupBox1.Controls.Add(this.rb5);
            this.groupBox1.Controls.Add(this.sortBtn);
            this.groupBox1.Controls.Add(this.rb4);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb3);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(1209, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(610, 483);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировать по:";
            // 
            // rb9
            // 
            this.rb9.AutoSize = true;
            this.rb9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb9.Location = new System.Drawing.Point(366, 328);
            this.rb9.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rb9.Name = "rb9";
            this.rb9.Size = new System.Drawing.Size(136, 33);
            this.rb9.TabIndex = 53;
            this.rb9.TabStop = true;
            this.rb9.Text = "выручке";
            this.rb9.UseVisualStyleBackColor = true;
            // 
            // rb8
            // 
            this.rb8.AutoSize = true;
            this.rb8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb8.Location = new System.Drawing.Point(310, 193);
            this.rb8.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rb8.Name = "rb8";
            this.rb8.Size = new System.Drawing.Size(276, 33);
            this.rb8.TabIndex = 52;
            this.rb8.TabStop = true;
            this.rb8.Text = "проценту надбавки";
            this.rb8.UseVisualStyleBackColor = true;
            // 
            // rb7
            // 
            this.rb7.AutoSize = true;
            this.rb7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb7.Location = new System.Drawing.Point(310, 60);
            this.rb7.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rb7.Name = "rb7";
            this.rb7.Size = new System.Drawing.Size(238, 33);
            this.rb7.TabIndex = 51;
            this.rb7.TabStop = true;
            this.rb7.Text = "сбору за экипаж";
            this.rb7.UseVisualStyleBackColor = true;
            // 
            // rb6
            // 
            this.rb6.AutoSize = true;
            this.rb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb6.Location = new System.Drawing.Point(34, 417);
            this.rb6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rb6.Name = "rb6";
            this.rb6.Size = new System.Drawing.Size(264, 33);
            this.rb6.TabIndex = 50;
            this.rb6.TabStop = true;
            this.rb6.Text = "по кол-ву экипажа";
            this.rb6.UseVisualStyleBackColor = true;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb5.Location = new System.Drawing.Point(34, 343);
            this.rb5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(280, 33);
            this.rb5.TabIndex = 49;
            this.rb5.TabStop = true;
            this.rb5.Text = "сбору за пассажира";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // sortBtn
            // 
            this.sortBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sortBtn.Location = new System.Drawing.Point(336, 396);
            this.sortBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(274, 88);
            this.sortBtn.TabIndex = 44;
            this.sortBtn.Text = "Сортировка";
            this.sortBtn.UseVisualStyleBackColor = false;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb4.Location = new System.Drawing.Point(34, 272);
            this.rb4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(307, 33);
            this.rb4.TabIndex = 48;
            this.rb4.TabStop = true;
            this.rb4.Text = "по кол-ву пассажиров";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb2.Location = new System.Drawing.Point(34, 121);
            this.rb2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(275, 33);
            this.rb2.TabIndex = 47;
            this.rb2.TabStop = true;
            this.rb2.Text = "времени прибытия";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb3.Location = new System.Drawing.Point(34, 193);
            this.rb3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(217, 33);
            this.rb3.TabIndex = 46;
            this.rb3.TabStop = true;
            this.rb3.Text = "типу самолёта";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb1.Location = new System.Drawing.Point(34, 60);
            this.rb1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(165, 33);
            this.rb1.TabIndex = 45;
            this.rb1.TabStop = true;
            this.rb1.Text = "коду учёта";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1224, 579);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 29);
            this.label3.TabIndex = 51;
            this.label3.Text = "Фильтр по цене";
            // 
            // filter_txt
            // 
            this.filter_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filter_txt.Location = new System.Drawing.Point(1472, 573);
            this.filter_txt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.filter_txt.Name = "filter_txt";
            this.filter_txt.Size = new System.Drawing.Size(131, 34);
            this.filter_txt.TabIndex = 52;
            // 
            // more_radio
            // 
            this.more_radio.AutoSize = true;
            this.more_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.more_radio.Location = new System.Drawing.Point(1647, 543);
            this.more_radio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.more_radio.Name = "more_radio";
            this.more_radio.Size = new System.Drawing.Size(125, 33);
            this.more_radio.TabIndex = 53;
            this.more_radio.TabStop = true;
            this.more_radio.Text = "Больше";
            this.more_radio.UseVisualStyleBackColor = true;
            // 
            // less_radio
            // 
            this.less_radio.AutoSize = true;
            this.less_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.less_radio.Location = new System.Drawing.Point(1647, 596);
            this.less_radio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.less_radio.Name = "less_radio";
            this.less_radio.Size = new System.Drawing.Size(130, 33);
            this.less_radio.TabIndex = 54;
            this.less_radio.TabStop = true;
            this.less_radio.Text = "Меньше";
            this.less_radio.UseVisualStyleBackColor = true;
            // 
            // expBtn
            // 
            this.expBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.expBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.expBtn.Location = new System.Drawing.Point(1358, 663);
            this.expBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.expBtn.Name = "expBtn";
            this.expBtn.Size = new System.Drawing.Size(288, 96);
            this.expBtn.TabIndex = 55;
            this.expBtn.Text = "Экспорт";
            this.expBtn.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AirportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1835, 811);
            this.Controls.Add(this.expBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filter_txt);
            this.Controls.Add(this.more_radio);
            this.Controls.Add(this.less_radio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.infoSS);
            this.Controls.Add(this.FlightsDGV);
            this.Controls.Add(this.toolsTS);
            this.Controls.Add(this.mainMenuMS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuMS;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(1194, 746);
            this.Name = "AirportForm";
            this.Text = "Аэропорт";
            this.mainMenuMS.ResumeLayout(false);
            this.mainMenuMS.PerformLayout();
            this.toolsTS.ResumeLayout(false);
            this.toolsTS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlightsDGV)).EndInit();
            this.infoSS.ResumeLayout(false);
            this.infoSS.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuMS;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem Correction;
        private System.Windows.Forms.ToolStripMenuItem AddMenu;
        private System.Windows.Forms.ToolStripMenuItem ChangeMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem DeliteMenu;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStrip toolsTS;
        private System.Windows.Forms.ToolStripButton AddTool;
        private System.Windows.Forms.ToolStripButton ChangeTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton DeliteTool;
        private System.Windows.Forms.DataGridView FlightsDGV;
        private System.Windows.Forms.StatusStrip infoSS;
        private System.Windows.Forms.ToolStripStatusLabel CountFlightsTSSL;
        private System.Windows.Forms.ToolStripStatusLabel SumTSSL;
        private System.Windows.Forms.ToolStripStatusLabel CountPasTSSL;
        private System.Windows.Forms.ToolStripStatusLabel CountCrewTSSL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filter_txt;
        private System.Windows.Forms.RadioButton more_radio;
        private System.Windows.Forms.RadioButton less_radio;
        private System.Windows.Forms.Button expBtn;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn numFlightColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countPasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price4PasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countCrewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price4CrewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procDopColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumColumn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton rb9;
        private System.Windows.Forms.RadioButton rb8;
        private System.Windows.Forms.RadioButton rb7;
        private System.Windows.Forms.RadioButton rb6;
    }
}

