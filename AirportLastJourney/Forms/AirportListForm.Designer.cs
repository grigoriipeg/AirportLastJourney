namespace AirportLastJourney.Forms
{
    partial class AirportListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBoxId = new TextBox();
            label3 = new Label();
            textBoxTime = new TextBox();
            label4 = new Label();
            textBoxPassCount = new TextBox();
            label5 = new Label();
            textBoxPassPrice = new TextBox();
            label6 = new Label();
            textBoxCrewCount = new TextBox();
            label7 = new Label();
            textBoxCrewPrice = new TextBox();
            label8 = new Label();
            textBoxPerc = new TextBox();
            label9 = new Label();
            textBoxSum = new TextBox();
            comboBoxType = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 93);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 1;
            label1.Text = "Тип самолёта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 64);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 3;
            label2.Text = "Номер рейса";
            // 
            // textBoxId
            // 
            textBoxId.Enabled = false;
            textBoxId.Location = new Point(176, 61);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(183, 23);
            textBoxId.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 122);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 5;
            label3.Text = "Время прибытия";
            // 
            // textBoxTime
            // 
            textBoxTime.Location = new Point(176, 119);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.Size = new Size(183, 23);
            textBoxTime.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 151);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 7;
            label4.Text = "Кол-во пассажиров";
            // 
            // textBoxPassCount
            // 
            textBoxPassCount.Location = new Point(176, 148);
            textBoxPassCount.Name = "textBoxPassCount";
            textBoxPassCount.Size = new Size(183, 23);
            textBoxPassCount.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 180);
            label5.Name = "label5";
            label5.Size = new Size(115, 15);
            label5.TabIndex = 9;
            label5.Text = "Сбор на пассажира";
            // 
            // textBoxPassPrice
            // 
            textBoxPassPrice.Location = new Point(176, 177);
            textBoxPassPrice.Name = "textBoxPassPrice";
            textBoxPassPrice.Size = new Size(183, 23);
            textBoxPassPrice.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 209);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 11;
            label6.Text = "Кол-во экипажа";
            // 
            // textBoxCrewCount
            // 
            textBoxCrewCount.Location = new Point(176, 206);
            textBoxCrewCount.Name = "textBoxCrewCount";
            textBoxCrewCount.Size = new Size(183, 23);
            textBoxCrewCount.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 238);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 13;
            label7.Text = "Сбор на экипаж";
            // 
            // textBoxCrewPrice
            // 
            textBoxCrewPrice.Location = new Point(176, 235);
            textBoxCrewPrice.Name = "textBoxCrewPrice";
            textBoxCrewPrice.Size = new Size(183, 23);
            textBoxCrewPrice.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(54, 267);
            label8.Name = "label8";
            label8.Size = new Size(109, 15);
            label8.TabIndex = 15;
            label8.Text = "Процент надбавки";
            // 
            // textBoxPerc
            // 
            textBoxPerc.Location = new Point(176, 264);
            textBoxPerc.Name = "textBoxPerc";
            textBoxPerc.Size = new Size(183, 23);
            textBoxPerc.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(54, 296);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 17;
            label9.Text = "Выручка";
            // 
            // textBoxSum
            // 
            textBoxSum.Location = new Point(176, 293);
            textBoxSum.Name = "textBoxSum";
            textBoxSum.Size = new Size(183, 23);
            textBoxSum.TabIndex = 16;
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(176, 90);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(183, 23);
            comboBoxType.TabIndex = 18;
            // 
            // AirportListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 386);
            Controls.Add(comboBoxType);
            Controls.Add(label9);
            Controls.Add(textBoxSum);
            Controls.Add(label8);
            Controls.Add(textBoxPerc);
            Controls.Add(label7);
            Controls.Add(textBoxCrewPrice);
            Controls.Add(label6);
            Controls.Add(textBoxCrewCount);
            Controls.Add(label5);
            Controls.Add(textBoxPassPrice);
            Controls.Add(label4);
            Controls.Add(textBoxPassCount);
            Controls.Add(label3);
            Controls.Add(textBoxTime);
            Controls.Add(label2);
            Controls.Add(textBoxId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AirportListForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Список";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox textBoxId;
        private Label label3;
        private TextBox textBoxTime;
        private Label label4;
        private TextBox textBoxPassCount;
        private Label label5;
        private TextBox textBoxPassPrice;
        private Label label6;
        private TextBox textBoxCrewCount;
        private Label label7;
        private TextBox textBoxCrewPrice;
        private Label label8;
        private TextBox textBoxPerc;
        private Label label9;
        private TextBox textBoxSum;
        private ComboBox comboBoxType;
    }
}