﻿namespace AirportLastJourney
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirportForm));
            mainMenuMS = new MenuStrip();
            File = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            экспортToolStripMenuItem = new ToolStripMenuItem();
            Correction = new ToolStripMenuItem();
            AddMenu = new ToolStripMenuItem();
            ChangeMenu = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            DeliteMenu = new ToolStripMenuItem();
            About = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            toolsTS = new ToolStrip();
            AddTool = new ToolStripButton();
            ChangeTool = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            DeliteTool = new ToolStripButton();
            FlightsDGV = new DataGridView();
            numFlightColumn = new DataGridViewTextBoxColumn();
            typeColumn = new DataGridViewTextBoxColumn();
            etaColumn = new DataGridViewTextBoxColumn();
            countPasColumn = new DataGridViewTextBoxColumn();
            price4PasColumn = new DataGridViewTextBoxColumn();
            countCrewColumn = new DataGridViewTextBoxColumn();
            price4CrewColumn = new DataGridViewTextBoxColumn();
            procDopColumn = new DataGridViewTextBoxColumn();
            sumColumn = new DataGridViewTextBoxColumn();
            infoSS = new StatusStrip();
            CountFlightsTSSL = new ToolStripStatusLabel();
            CountPasTSSL = new ToolStripStatusLabel();
            CountCrewTSSL = new ToolStripStatusLabel();
            SumTSSL = new ToolStripStatusLabel();
            groupBox1 = new GroupBox();
            radioButtonDownTo = new RadioButton();
            radioButtonUpTo = new RadioButton();
            comboBoxSort = new ComboBox();
            label3 = new Label();
            filter_txt = new TextBox();
            more_radio = new RadioButton();
            less_radio = new RadioButton();
            expBtn = new Button();
            openFileDialog1 = new OpenFileDialog();
            mainMenuMS.SuspendLayout();
            toolsTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FlightsDGV).BeginInit();
            infoSS.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuMS
            // 
            mainMenuMS.ImageScalingSize = new Size(20, 20);
            mainMenuMS.Items.AddRange(new ToolStripItem[] { File, Correction, About, выходToolStripMenuItem });
            mainMenuMS.Location = new Point(0, 0);
            mainMenuMS.Name = "mainMenuMS";
            mainMenuMS.Padding = new Padding(7, 2, 0, 2);
            mainMenuMS.Size = new Size(1608, 24);
            mainMenuMS.TabIndex = 0;
            mainMenuMS.Text = "menuStrip1";
            // 
            // File
            // 
            File.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьToolStripMenuItem, экспортToolStripMenuItem });
            File.Name = "File";
            File.Size = new Size(48, 20);
            File.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(133, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(133, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // экспортToolStripMenuItem
            // 
            экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            экспортToolStripMenuItem.Size = new Size(133, 22);
            экспортToolStripMenuItem.Text = "Экспорт";
            экспортToolStripMenuItem.Click += expBtn_Click;
            // 
            // Correction
            // 
            Correction.DropDownItems.AddRange(new ToolStripItem[] { AddMenu, ChangeMenu, toolStripSeparator1, DeliteMenu });
            Correction.Name = "Correction";
            Correction.Size = new Size(59, 20);
            Correction.Text = "Правка";
            // 
            // AddMenu
            // 
            AddMenu.Name = "AddMenu";
            AddMenu.Size = new Size(128, 22);
            AddMenu.Text = "Добавить";
            // 
            // ChangeMenu
            // 
            ChangeMenu.Enabled = false;
            ChangeMenu.Name = "ChangeMenu";
            ChangeMenu.Size = new Size(128, 22);
            ChangeMenu.Text = "Изменить";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(125, 6);
            // 
            // DeliteMenu
            // 
            DeliteMenu.Enabled = false;
            DeliteMenu.Name = "DeliteMenu";
            DeliteMenu.Size = new Size(128, 22);
            DeliteMenu.Text = "Удалить";
            // 
            // About
            // 
            About.Name = "About";
            About.Size = new Size(94, 20);
            About.Text = "О программе";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(54, 20);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // toolsTS
            // 
            toolsTS.ImageScalingSize = new Size(20, 20);
            toolsTS.Items.AddRange(new ToolStripItem[] { AddTool, ChangeTool, toolStripSeparator2, DeliteTool });
            toolsTS.Location = new Point(0, 24);
            toolsTS.Name = "toolsTS";
            toolsTS.Size = new Size(1608, 25);
            toolsTS.TabIndex = 1;
            toolsTS.Text = "toolStrip1";
            // 
            // AddTool
            // 
            AddTool.ImageTransparentColor = Color.Magenta;
            AddTool.Name = "AddTool";
            AddTool.Size = new Size(63, 22);
            AddTool.Text = "Добавить";
            AddTool.Click += AddTool_Click;
            // 
            // ChangeTool
            // 
            ChangeTool.Enabled = false;
            ChangeTool.ImageTransparentColor = Color.Magenta;
            ChangeTool.Name = "ChangeTool";
            ChangeTool.Size = new Size(65, 22);
            ChangeTool.Text = "Изменить";
            ChangeTool.Click += ChangeTool_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // DeliteTool
            // 
            DeliteTool.Enabled = false;
            DeliteTool.ImageTransparentColor = Color.Magenta;
            DeliteTool.Name = "DeliteTool";
            DeliteTool.Size = new Size(55, 22);
            DeliteTool.Text = "Удалить";
            DeliteTool.Click += DeleteTool_Click;
            // 
            // FlightsDGV
            // 
            FlightsDGV.AllowUserToAddRows = false;
            FlightsDGV.AllowUserToDeleteRows = false;
            FlightsDGV.AllowUserToResizeColumns = false;
            FlightsDGV.AllowUserToResizeRows = false;
            FlightsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FlightsDGV.Columns.AddRange(new DataGridViewColumn[] { numFlightColumn, typeColumn, etaColumn, countPasColumn, price4PasColumn, countCrewColumn, price4CrewColumn, procDopColumn, sumColumn });
            FlightsDGV.EditMode = DataGridViewEditMode.EditProgrammatically;
            FlightsDGV.Location = new Point(0, 57);
            FlightsDGV.Margin = new Padding(4, 3, 4, 3);
            FlightsDGV.MultiSelect = false;
            FlightsDGV.Name = "FlightsDGV";
            FlightsDGV.ReadOnly = true;
            FlightsDGV.RowHeadersVisible = false;
            FlightsDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle9.NullValue = "fgn";
            FlightsDGV.RowsDefaultCellStyle = dataGridViewCellStyle9;
            FlightsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FlightsDGV.Size = new Size(1027, 526);
            FlightsDGV.TabIndex = 2;
            FlightsDGV.SelectionChanged += FlightsDGV_SelectionChanged;
            FlightsDGV.Paint += FlightsDGV_Paint;
            // 
            // numFlightColumn
            // 
            numFlightColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            numFlightColumn.DataPropertyName = "id_flight";
            dataGridViewCellStyle1.Format = "####";
            dataGridViewCellStyle1.NullValue = null;
            numFlightColumn.DefaultCellStyle = dataGridViewCellStyle1;
            numFlightColumn.HeaderText = "Номер рейса";
            numFlightColumn.MinimumWidth = 6;
            numFlightColumn.Name = "numFlightColumn";
            numFlightColumn.ReadOnly = true;
            // 
            // typeColumn
            // 
            typeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            typeColumn.DataPropertyName = "Type";
            typeColumn.HeaderText = "Тип самолёта";
            typeColumn.MinimumWidth = 6;
            typeColumn.Name = "typeColumn";
            typeColumn.ReadOnly = true;
            // 
            // etaColumn
            // 
            etaColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            etaColumn.DataPropertyName = "ETA";
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            etaColumn.DefaultCellStyle = dataGridViewCellStyle2;
            etaColumn.HeaderText = "Время прибытия";
            etaColumn.MinimumWidth = 6;
            etaColumn.Name = "etaColumn";
            etaColumn.ReadOnly = true;
            // 
            // countPasColumn
            // 
            countPasColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            countPasColumn.DataPropertyName = "CountPas";
            dataGridViewCellStyle3.Format = "N0";
            countPasColumn.DefaultCellStyle = dataGridViewCellStyle3;
            countPasColumn.HeaderText = "Кол-во пассажиров";
            countPasColumn.MinimumWidth = 6;
            countPasColumn.Name = "countPasColumn";
            countPasColumn.ReadOnly = true;
            // 
            // price4PasColumn
            // 
            price4PasColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            price4PasColumn.DataPropertyName = "PricePas";
            dataGridViewCellStyle4.Format = "C2";
            price4PasColumn.DefaultCellStyle = dataGridViewCellStyle4;
            price4PasColumn.HeaderText = "Сбор на пассажира";
            price4PasColumn.MinimumWidth = 6;
            price4PasColumn.Name = "price4PasColumn";
            price4PasColumn.ReadOnly = true;
            // 
            // countCrewColumn
            // 
            countCrewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            countCrewColumn.DataPropertyName = "CountCrew";
            dataGridViewCellStyle5.Format = "N0";
            countCrewColumn.DefaultCellStyle = dataGridViewCellStyle5;
            countCrewColumn.HeaderText = "Кол-во экипажа";
            countCrewColumn.MinimumWidth = 6;
            countCrewColumn.Name = "countCrewColumn";
            countCrewColumn.ReadOnly = true;
            // 
            // price4CrewColumn
            // 
            price4CrewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            price4CrewColumn.DataPropertyName = "PriceCrew";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            price4CrewColumn.DefaultCellStyle = dataGridViewCellStyle6;
            price4CrewColumn.HeaderText = "Сбор на экипаж";
            price4CrewColumn.MinimumWidth = 6;
            price4CrewColumn.Name = "price4CrewColumn";
            price4CrewColumn.ReadOnly = true;
            // 
            // procDopColumn
            // 
            procDopColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            procDopColumn.DataPropertyName = "ProcDop";
            dataGridViewCellStyle7.Format = "N2";
            procDopColumn.DefaultCellStyle = dataGridViewCellStyle7;
            procDopColumn.HeaderText = "Процент надбавки";
            procDopColumn.MinimumWidth = 6;
            procDopColumn.Name = "procDopColumn";
            procDopColumn.ReadOnly = true;
            // 
            // sumColumn
            // 
            sumColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sumColumn.DataPropertyName = "Sum";
            dataGridViewCellStyle8.Format = "C2";
            sumColumn.DefaultCellStyle = dataGridViewCellStyle8;
            sumColumn.HeaderText = "Выручка";
            sumColumn.MinimumWidth = 6;
            sumColumn.Name = "sumColumn";
            sumColumn.ReadOnly = true;
            // 
            // infoSS
            // 
            infoSS.ImageScalingSize = new Size(20, 20);
            infoSS.Items.AddRange(new ToolStripItem[] { CountFlightsTSSL, CountPasTSSL, CountCrewTSSL, SumTSSL });
            infoSS.Location = new Point(0, 599);
            infoSS.Name = "infoSS";
            infoSS.Padding = new Padding(1, 0, 16, 0);
            infoSS.Size = new Size(1608, 22);
            infoSS.TabIndex = 3;
            infoSS.Text = "statusStrip1";
            // 
            // CountFlightsTSSL
            // 
            CountFlightsTSSL.Name = "CountFlightsTSSL";
            CountFlightsTSSL.Size = new Size(97, 17);
            CountFlightsTSSL.Text = "Кол-во рейсов 0";
            // 
            // CountPasTSSL
            // 
            CountPasTSSL.Name = "CountPasTSSL";
            CountPasTSSL.Size = new Size(117, 17);
            CountPasTSSL.Text = "Всего пассажиров 0";
            // 
            // CountCrewTSSL
            // 
            CountCrewTSSL.Name = "CountCrewTSSL";
            CountCrewTSSL.Size = new Size(97, 17);
            CountCrewTSSL.Text = "Всего экипажа 0";
            // 
            // SumTSSL
            // 
            SumTSSL.Name = "SumTSSL";
            SumTSSL.Size = new Size(105, 17);
            SumTSSL.Text = "Общая выручка 0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonDownTo);
            groupBox1.Controls.Add(radioButtonUpTo);
            groupBox1.Controls.Add(comboBoxSort);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(1058, 28);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(534, 109);
            groupBox1.TabIndex = 50;
            groupBox1.TabStop = false;
            groupBox1.Text = "Сортировать по:";
            // 
            // radioButtonDownTo
            // 
            radioButtonDownTo.AutoSize = true;
            radioButtonDownTo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonDownTo.Location = new Point(422, 51);
            radioButtonDownTo.Name = "radioButtonDownTo";
            radioButtonDownTo.Size = new Size(105, 24);
            radioButtonDownTo.TabIndex = 56;
            radioButtonDownTo.Text = "Убыванию";
            radioButtonDownTo.UseVisualStyleBackColor = true;
            radioButtonDownTo.Click += radioButton_Click;
            // 
            // radioButtonUpTo
            // 
            radioButtonUpTo.AutoSize = true;
            radioButtonUpTo.Checked = true;
            radioButtonUpTo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonUpTo.Location = new Point(287, 51);
            radioButtonUpTo.Name = "radioButtonUpTo";
            radioButtonUpTo.Size = new Size(129, 24);
            radioButtonUpTo.TabIndex = 55;
            radioButtonUpTo.TabStop = true;
            radioButtonUpTo.Text = "Возрастанию";
            radioButtonUpTo.UseVisualStyleBackColor = true;
            radioButtonUpTo.Click += radioButton_Click;
            // 
            // comboBoxSort
            // 
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Location = new Point(30, 47);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(245, 28);
            comboBoxSort.TabIndex = 54;
            comboBoxSort.SelectedIndexChanged += comboBoxSort_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1071, 434);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(169, 24);
            label3.TabIndex = 51;
            label3.Text = "Фильтр по цене";
            // 
            // filter_txt
            // 
            filter_txt.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            filter_txt.Location = new Point(1288, 430);
            filter_txt.Margin = new Padding(4, 3, 4, 3);
            filter_txt.Name = "filter_txt";
            filter_txt.Size = new Size(115, 29);
            filter_txt.TabIndex = 52;
            // 
            // more_radio
            // 
            more_radio.AutoSize = true;
            more_radio.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            more_radio.Location = new Point(1441, 407);
            more_radio.Margin = new Padding(4, 3, 4, 3);
            more_radio.Name = "more_radio";
            more_radio.Size = new Size(98, 28);
            more_radio.TabIndex = 53;
            more_radio.TabStop = true;
            more_radio.Text = "Больше";
            more_radio.UseVisualStyleBackColor = true;
            // 
            // less_radio
            // 
            less_radio.AutoSize = true;
            less_radio.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            less_radio.Location = new Point(1441, 447);
            less_radio.Margin = new Padding(4, 3, 4, 3);
            less_radio.Name = "less_radio";
            less_radio.Size = new Size(102, 28);
            less_radio.TabIndex = 54;
            less_radio.TabStop = true;
            less_radio.Text = "Меньше";
            less_radio.UseVisualStyleBackColor = true;
            // 
            // expBtn
            // 
            expBtn.BackColor = SystemColors.ControlLight;
            expBtn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            expBtn.Location = new Point(1188, 497);
            expBtn.Margin = new Padding(4, 3, 4, 3);
            expBtn.Name = "expBtn";
            expBtn.Size = new Size(252, 72);
            expBtn.TabIndex = 55;
            expBtn.Text = "Экспорт";
            expBtn.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // AirportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1608, 621);
            Controls.Add(expBtn);
            Controls.Add(label3);
            Controls.Add(filter_txt);
            Controls.Add(more_radio);
            Controls.Add(less_radio);
            Controls.Add(groupBox1);
            Controls.Add(infoSS);
            Controls.Add(FlightsDGV);
            Controls.Add(toolsTS);
            Controls.Add(mainMenuMS);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mainMenuMS;
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1047, 569);
            Name = "AirportForm";
            Text = "Аэропорт";
            FormClosed += AirportForm_FormClosed;
            mainMenuMS.ResumeLayout(false);
            mainMenuMS.PerformLayout();
            toolsTS.ResumeLayout(false);
            toolsTS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FlightsDGV).EndInit();
            infoSS.ResumeLayout(false);
            infoSS.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ComboBox comboBoxSort;
        private RadioButton radioButtonDownTo;
        private RadioButton radioButtonUpTo;
    }
}

