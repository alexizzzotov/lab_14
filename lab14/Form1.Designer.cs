﻿
namespace lab14
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbAllPeople = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPeople = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numSer = new System.Windows.Forms.NumericUpDown();
            this.numOperator = new System.Windows.Forms.NumericUpDown();
            this.numVhod = new System.Windows.Forms.NumericUpDown();
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOperator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVhod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbAllPeople);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbPeople);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numSer);
            this.panel1.Controls.Add(this.numOperator);
            this.panel1.Controls.Add(this.numVhod);
            this.panel1.Controls.Add(this.btStop);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1404, 152);
            this.panel1.TabIndex = 0;
            // 
            // lbAllPeople
            // 
            this.lbAllPeople.AutoSize = true;
            this.lbAllPeople.Location = new System.Drawing.Point(743, 48);
            this.lbAllPeople.Name = "lbAllPeople";
            this.lbAllPeople.Size = new System.Drawing.Size(20, 17);
            this.lbAllPeople.TabIndex = 5;
            this.lbAllPeople.Text = " 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Всего людей:";
            // 
            // lbPeople
            // 
            this.lbPeople.AutoSize = true;
            this.lbPeople.Location = new System.Drawing.Point(743, 84);
            this.lbPeople.Name = "lbPeople";
            this.lbPeople.Size = new System.Drawing.Size(20, 17);
            this.lbPeople.TabIndex = 3;
            this.lbPeople.Text = " 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 85);
            this.label2.TabIndex = 6;
            this.label2.Text = "Количество операторов\r\n\r\nСервисный параметр\r\n\r\nПараметр для входящего потока";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(632, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "В очереди:";
            // 
            // numSer
            // 
            this.numSer.Location = new System.Drawing.Point(476, 65);
            this.numSer.Name = "numSer";
            this.numSer.Size = new System.Drawing.Size(78, 22);
            this.numSer.TabIndex = 4;
            this.numSer.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numOperator
            // 
            this.numOperator.Location = new System.Drawing.Point(476, 30);
            this.numOperator.Name = "numOperator";
            this.numOperator.Size = new System.Drawing.Size(78, 22);
            this.numOperator.TabIndex = 3;
            this.numOperator.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numVhod
            // 
            this.numVhod.Location = new System.Drawing.Point(476, 100);
            this.numVhod.Name = "numVhod";
            this.numVhod.Size = new System.Drawing.Size(78, 22);
            this.numVhod.TabIndex = 2;
            this.numVhod.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // btStop
            // 
            this.btStop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStop.Location = new System.Drawing.Point(36, 79);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(128, 38);
            this.btStop.TabIndex = 1;
            this.btStop.Text = "Стоп";
            this.btStop.UseVisualStyleBackColor = false;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.Location = new System.Drawing.Point(36, 33);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(128, 38);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Старт";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            this.chart1.Location = new System.Drawing.Point(12, 158);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(1380, 559);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(560, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 729);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOperator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVhod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSer;
        private System.Windows.Forms.NumericUpDown numOperator;
        private System.Windows.Forms.NumericUpDown numVhod;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPeople;
        private System.Windows.Forms.Label lbAllPeople;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

