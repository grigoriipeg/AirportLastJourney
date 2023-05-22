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
            this.radioButtonDownTo = new System.Windows.Forms.RadioButton();
            this.radioButtonUpTo = new System.Windows.Forms.RadioButton();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.expBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCrewTo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCrewFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPassTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPassFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.checkBoxCrewCount = new System.Windows.Forms.CheckBox();
            this.checkBoxPassCount = new System.Windows.Forms.CheckBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.checkBoxType = new System.Windows.Forms.CheckBox();
            this.checkBoxSum = new System.Windows.Forms.CheckBox();
            this.labelNullError = new System.Windows.Forms.Label();
            this.buttonList = new System.Windows.Forms.Button();
            this.mainMenuMS.SuspendLayout();
            this.toolsTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlightsDGV)).BeginInit();
            this.infoSS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.mainMenuMS.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mainMenuMS.Size = new System.Drawing.Size(1616, 24);
            this.mainMenuMS.TabIndex = 0;
            this.mainMenuMS.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.экспортToolStripMenuItem});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(48, 20);
            this.File.Text = "Файл";
            // 
            // экспортToolStripMenuItem
            // 
            this.экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            this.экспортToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.экспортToolStripMenuItem.Text = "Экспорт";
            this.экспортToolStripMenuItem.Click += new System.EventHandler(this.expBtn_Click);
            // 
            // Correction
            // 
            this.Correction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMenu,
            this.ChangeMenu,
            this.toolStripSeparator1,
            this.DeliteMenu});
            this.Correction.Name = "Correction";
            this.Correction.Size = new System.Drawing.Size(59, 20);
            this.Correction.Text = "Правка";
            // 
            // AddMenu
            // 
            this.AddMenu.Name = "AddMenu";
            this.AddMenu.Size = new System.Drawing.Size(128, 22);
            this.AddMenu.Text = "Добавить";
            this.AddMenu.Click += new System.EventHandler(this.AddTool_Click);
            // 
            // ChangeMenu
            // 
            this.ChangeMenu.Enabled = false;
            this.ChangeMenu.Name = "ChangeMenu";
            this.ChangeMenu.Size = new System.Drawing.Size(128, 22);
            this.ChangeMenu.Text = "Изменить";
            this.ChangeMenu.Click += new System.EventHandler(this.ChangeTool_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // DeliteMenu
            // 
            this.DeliteMenu.Enabled = false;
            this.DeliteMenu.Name = "DeliteMenu";
            this.DeliteMenu.Size = new System.Drawing.Size(128, 22);
            this.DeliteMenu.Text = "Удалить";
            this.DeliteMenu.Click += new System.EventHandler(this.DeleteTool_Click);
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(65, 20);
            this.About.Text = "Справка";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // toolsTS
            // 
            this.toolsTS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolsTS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTool,
            this.ChangeTool,
            this.toolStripSeparator2,
            this.DeliteTool});
            this.toolsTS.Location = new System.Drawing.Point(0, 24);
            this.toolsTS.Name = "toolsTS";
            this.toolsTS.Size = new System.Drawing.Size(1616, 25);
            this.toolsTS.TabIndex = 1;
            this.toolsTS.Text = "toolStrip1";
            // 
            // AddTool
            // 
            this.AddTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddTool.Name = "AddTool";
            this.AddTool.Size = new System.Drawing.Size(63, 22);
            this.AddTool.Text = "Добавить";
            this.AddTool.Click += new System.EventHandler(this.AddTool_Click);
            // 
            // ChangeTool
            // 
            this.ChangeTool.Enabled = false;
            this.ChangeTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChangeTool.Name = "ChangeTool";
            this.ChangeTool.Size = new System.Drawing.Size(65, 22);
            this.ChangeTool.Text = "Изменить";
            this.ChangeTool.Click += new System.EventHandler(this.ChangeTool_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // DeliteTool
            // 
            this.DeliteTool.Enabled = false;
            this.DeliteTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeliteTool.Name = "DeliteTool";
            this.DeliteTool.Size = new System.Drawing.Size(55, 22);
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
            this.FlightsDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.FlightsDGV.Location = new System.Drawing.Point(0, 57);
            this.FlightsDGV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FlightsDGV.MultiSelect = false;
            this.FlightsDGV.Name = "FlightsDGV";
            this.FlightsDGV.ReadOnly = true;
            this.FlightsDGV.RowHeadersVisible = false;
            this.FlightsDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle9.NullValue = "fgn";
            this.FlightsDGV.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.FlightsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FlightsDGV.Size = new System.Drawing.Size(1027, 526);
            this.FlightsDGV.TabIndex = 2;
            this.FlightsDGV.SelectionChanged += new System.EventHandler(this.FlightsDGV_SelectionChanged);
            this.FlightsDGV.Paint += new System.Windows.Forms.PaintEventHandler(this.FlightsDGV_Paint);
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
            this.infoSS.Location = new System.Drawing.Point(0, 594);
            this.infoSS.Name = "infoSS";
            this.infoSS.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.infoSS.Size = new System.Drawing.Size(1616, 22);
            this.infoSS.TabIndex = 3;
            this.infoSS.Text = "statusStrip1";
            // 
            // CountFlightsTSSL
            // 
            this.CountFlightsTSSL.Name = "CountFlightsTSSL";
            this.CountFlightsTSSL.Size = new System.Drawing.Size(97, 17);
            this.CountFlightsTSSL.Text = "Кол-во рейсов 0";
            // 
            // CountPasTSSL
            // 
            this.CountPasTSSL.Name = "CountPasTSSL";
            this.CountPasTSSL.Size = new System.Drawing.Size(117, 17);
            this.CountPasTSSL.Text = "Всего пассажиров 0";
            // 
            // CountCrewTSSL
            // 
            this.CountCrewTSSL.Name = "CountCrewTSSL";
            this.CountCrewTSSL.Size = new System.Drawing.Size(97, 17);
            this.CountCrewTSSL.Text = "Всего экипажа 0";
            // 
            // SumTSSL
            // 
            this.SumTSSL.Name = "SumTSSL";
            this.SumTSSL.Size = new System.Drawing.Size(105, 17);
            this.SumTSSL.Text = "Общая выручка 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDownTo);
            this.groupBox1.Controls.Add(this.radioButtonUpTo);
            this.groupBox1.Controls.Add(this.comboBoxSort);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(1061, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(534, 109);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировать по:";
            // 
            // radioButtonDownTo
            // 
            this.radioButtonDownTo.AutoSize = true;
            this.radioButtonDownTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonDownTo.Location = new System.Drawing.Point(422, 51);
            this.radioButtonDownTo.Name = "radioButtonDownTo";
            this.radioButtonDownTo.Size = new System.Drawing.Size(105, 24);
            this.radioButtonDownTo.TabIndex = 56;
            this.radioButtonDownTo.Text = "Убыванию";
            this.radioButtonDownTo.UseVisualStyleBackColor = true;
            this.radioButtonDownTo.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButtonUpTo
            // 
            this.radioButtonUpTo.AutoSize = true;
            this.radioButtonUpTo.Checked = true;
            this.radioButtonUpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonUpTo.Location = new System.Drawing.Point(287, 51);
            this.radioButtonUpTo.Name = "radioButtonUpTo";
            this.radioButtonUpTo.Size = new System.Drawing.Size(129, 24);
            this.radioButtonUpTo.TabIndex = 55;
            this.radioButtonUpTo.TabStop = true;
            this.radioButtonUpTo.Text = "Возрастанию";
            this.radioButtonUpTo.UseVisualStyleBackColor = true;
            this.radioButtonUpTo.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Location = new System.Drawing.Point(30, 47);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(245, 28);
            this.comboBoxSort.TabIndex = 54;
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            // 
            // expBtn
            // 
            this.expBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.expBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.expBtn.Location = new System.Drawing.Point(1203, 511);
            this.expBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.expBtn.Name = "expBtn";
            this.expBtn.Size = new System.Drawing.Size(252, 72);
            this.expBtn.TabIndex = 55;
            this.expBtn.Text = "Экспорт";
            this.expBtn.UseVisualStyleBackColor = false;
            this.expBtn.Click += new System.EventHandler(this.expBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxCrewTo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxCrewFrom);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxPassTo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxPassFrom);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxTo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxFrom);
            this.groupBox2.Controls.Add(this.checkBoxCrewCount);
            this.groupBox2.Controls.Add(this.checkBoxPassCount);
            this.groupBox2.Controls.Add(this.comboBoxType);
            this.groupBox2.Controls.Add(this.checkBoxType);
            this.groupBox2.Controls.Add(this.checkBoxSum);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(1061, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 193);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтры";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 28);
            this.label5.TabIndex = 81;
            this.label5.Text = "до";
            // 
            // textBoxCrewTo
            // 
            this.textBoxCrewTo.Enabled = false;
            this.textBoxCrewTo.Location = new System.Drawing.Point(439, 146);
            this.textBoxCrewTo.Name = "textBoxCrewTo";
            this.textBoxCrewTo.Size = new System.Drawing.Size(88, 33);
            this.textBoxCrewTo.TabIndex = 80;
            this.textBoxCrewTo.TextChanged += new System.EventHandler(this.textBoxFromTo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 28);
            this.label6.TabIndex = 79;
            this.label6.Text = "от";
            // 
            // textBoxCrewFrom
            // 
            this.textBoxCrewFrom.Enabled = false;
            this.textBoxCrewFrom.Location = new System.Drawing.Point(308, 146);
            this.textBoxCrewFrom.Name = "textBoxCrewFrom";
            this.textBoxCrewFrom.Size = new System.Drawing.Size(88, 33);
            this.textBoxCrewFrom.TabIndex = 78;
            this.textBoxCrewFrom.TextChanged += new System.EventHandler(this.textBoxFromTo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 28);
            this.label3.TabIndex = 77;
            this.label3.Text = "до";
            // 
            // textBoxPassTo
            // 
            this.textBoxPassTo.Enabled = false;
            this.textBoxPassTo.Location = new System.Drawing.Point(439, 108);
            this.textBoxPassTo.Name = "textBoxPassTo";
            this.textBoxPassTo.Size = new System.Drawing.Size(88, 33);
            this.textBoxPassTo.TabIndex = 76;
            this.textBoxPassTo.TextChanged += new System.EventHandler(this.textBoxFromTo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 28);
            this.label4.TabIndex = 75;
            this.label4.Text = "от";
            // 
            // textBoxPassFrom
            // 
            this.textBoxPassFrom.Enabled = false;
            this.textBoxPassFrom.Location = new System.Drawing.Point(308, 108);
            this.textBoxPassFrom.Name = "textBoxPassFrom";
            this.textBoxPassFrom.Size = new System.Drawing.Size(88, 33);
            this.textBoxPassFrom.TabIndex = 74;
            this.textBoxPassFrom.TextChanged += new System.EventHandler(this.textBoxFromTo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 28);
            this.label2.TabIndex = 73;
            this.label2.Text = "до";
            // 
            // textBoxTo
            // 
            this.textBoxTo.Enabled = false;
            this.textBoxTo.Location = new System.Drawing.Point(402, 32);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(126, 33);
            this.textBoxTo.TabIndex = 72;
            this.textBoxTo.TextChanged += new System.EventHandler(this.textBoxFromTo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 28);
            this.label1.TabIndex = 71;
            this.label1.Text = "от";
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Enabled = false;
            this.textBoxFrom.Location = new System.Drawing.Point(228, 32);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(128, 33);
            this.textBoxFrom.TabIndex = 70;
            this.textBoxFrom.TextChanged += new System.EventHandler(this.textBoxFromTo_TextChanged);
            // 
            // checkBoxCrewCount
            // 
            this.checkBoxCrewCount.AutoSize = true;
            this.checkBoxCrewCount.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxCrewCount.Location = new System.Drawing.Point(15, 146);
            this.checkBoxCrewCount.Name = "checkBoxCrewCount";
            this.checkBoxCrewCount.Size = new System.Drawing.Size(207, 32);
            this.checkBoxCrewCount.TabIndex = 68;
            this.checkBoxCrewCount.Text = "По кол-ву экипажа";
            this.checkBoxCrewCount.UseVisualStyleBackColor = true;
            this.checkBoxCrewCount.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // checkBoxPassCount
            // 
            this.checkBoxPassCount.AutoSize = true;
            this.checkBoxPassCount.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxPassCount.Location = new System.Drawing.Point(15, 108);
            this.checkBoxPassCount.Name = "checkBoxPassCount";
            this.checkBoxPassCount.Size = new System.Drawing.Size(241, 32);
            this.checkBoxPassCount.TabIndex = 66;
            this.checkBoxPassCount.Text = "По кол-ву пассажиров";
            this.checkBoxPassCount.UseVisualStyleBackColor = true;
            this.checkBoxPassCount.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.Enabled = false;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(256, 70);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(272, 33);
            this.comboBoxType.TabIndex = 65;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // checkBoxType
            // 
            this.checkBoxType.AutoSize = true;
            this.checkBoxType.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxType.Location = new System.Drawing.Point(15, 70);
            this.checkBoxType.Name = "checkBoxType";
            this.checkBoxType.Size = new System.Drawing.Size(193, 32);
            this.checkBoxType.TabIndex = 64;
            this.checkBoxType.Text = "По типу самолёта";
            this.checkBoxType.UseVisualStyleBackColor = true;
            this.checkBoxType.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // checkBoxSum
            // 
            this.checkBoxSum.AutoSize = true;
            this.checkBoxSum.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxSum.Location = new System.Drawing.Point(15, 32);
            this.checkBoxSum.Name = "checkBoxSum";
            this.checkBoxSum.Size = new System.Drawing.Size(140, 32);
            this.checkBoxSum.TabIndex = 62;
            this.checkBoxSum.Text = "По выручке";
            this.checkBoxSum.UseVisualStyleBackColor = true;
            this.checkBoxSum.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // labelNullError
            // 
            this.labelNullError.AutoSize = true;
            this.labelNullError.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNullError.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelNullError.Location = new System.Drawing.Point(1150, 459);
            this.labelNullError.Name = "labelNullError";
            this.labelNullError.Size = new System.Drawing.Size(359, 25);
            this.labelNullError.TabIndex = 57;
            this.labelNullError.Text = "По вашему запросу ничего не найдено!";
            this.labelNullError.Visible = false;
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(1061, 190);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(75, 23);
            this.buttonList.TabIndex = 58;
            this.buttonList.Text = "Списком";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // AirportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 616);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.labelNullError);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.expBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.infoSS);
            this.Controls.Add(this.FlightsDGV);
            this.Controls.Add(this.toolsTS);
            this.Controls.Add(this.mainMenuMS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuMS;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1047, 569);
            this.Name = "AirportForm";
            this.Text = "Аэропорт";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AirportForm_FormClosed);
            this.mainMenuMS.ResumeLayout(false);
            this.mainMenuMS.PerformLayout();
            this.toolsTS.ResumeLayout(false);
            this.toolsTS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlightsDGV)).EndInit();
            this.infoSS.ResumeLayout(false);
            this.infoSS.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button expBtn;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
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
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ComboBox comboBoxSort;
        private RadioButton radioButtonDownTo;
        private RadioButton radioButtonUpTo;
        private GroupBox groupBox2;
        private ComboBox comboBoxType;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Label label2;
        private TextBox textBoxTo;
        private Label label1;
        private TextBox textBoxFrom;
        private CheckBox checkBoxCrewCount;
        private CheckBox checkBoxPassCount;
        private CheckBox checkBoxType;
        private CheckBox checkBoxSum;
        private Label label5;
        private TextBox textBoxCrewTo;
        private Label label6;
        private TextBox textBoxCrewFrom;
        private Label label3;
        private TextBox textBoxPassTo;
        private Label label4;
        private TextBox textBoxPassFrom;
        private Label labelNullError;
        private Button buttonList;
    }
}

