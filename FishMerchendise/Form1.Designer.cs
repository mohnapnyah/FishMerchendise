
namespace FishMerchendise
{
    partial class FishMerchendise
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.KindFish = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Temperature = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.MaxTemp = new System.Windows.Forms.Label();
            this.MinTemperature = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.TemperatureStack = new System.Windows.Forms.Label();
            this.Temps = new System.Windows.Forms.TextBox();
            this.MinTemperatureValue = new System.Windows.Forms.TextBox();
            this.MinTimeValue = new System.Windows.Forms.TextBox();
            this.MaxTimeValue = new System.Windows.Forms.TextBox();
            this.MaxTemperatureValue = new System.Windows.Forms.TextBox();
            this.TakeReport = new System.Windows.Forms.Button();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // KindFish
            // 
            this.KindFish.AutoSize = true;
            this.KindFish.Location = new System.Drawing.Point(12, 57);
            this.KindFish.Name = "KindFish";
            this.KindFish.Size = new System.Drawing.Size(62, 15);
            this.KindFish.TabIndex = 0;
            this.KindFish.Text = "Вид рыбы";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // Temperature
            // 
            this.Temperature.AutoSize = true;
            this.Temperature.Location = new System.Drawing.Point(66, 106);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(78, 15);
            this.Temperature.TabIndex = 2;
            this.Temperature.Text = "Температура";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(176, 106);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(42, 15);
            this.Time.TabIndex = 3;
            this.Time.Text = "Время";
            // 
            // MaxTemp
            // 
            this.MaxTemp.AutoSize = true;
            this.MaxTemp.Location = new System.Drawing.Point(12, 137);
            this.MaxTemp.Name = "MaxTemp";
            this.MaxTemp.Size = new System.Drawing.Size(30, 15);
            this.MaxTemp.TabIndex = 4;
            this.MaxTemp.Text = "Max";
            // 
            // MinTemperature
            // 
            this.MinTemperature.AutoSize = true;
            this.MinTemperature.Location = new System.Drawing.Point(12, 173);
            this.MinTemperature.Name = "MinTemperature";
            this.MinTemperature.Size = new System.Drawing.Size(28, 15);
            this.MinTemperature.TabIndex = 5;
            this.MinTemperature.Text = "Min";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.BackColor = System.Drawing.SystemColors.Control;
            this.Date.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Date.Location = new System.Drawing.Point(12, 219);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(32, 15);
            this.Date.TabIndex = 7;
            this.Date.Text = "Дата";
            // 
            // TemperatureStack
            // 
            this.TemperatureStack.AutoSize = true;
            this.TemperatureStack.Location = new System.Drawing.Point(12, 263);
            this.TemperatureStack.Name = "TemperatureStack";
            this.TemperatureStack.Size = new System.Drawing.Size(78, 15);
            this.TemperatureStack.TabIndex = 8;
            this.TemperatureStack.Text = "Температура";
            // 
            // Temps
            // 
            this.Temps.Location = new System.Drawing.Point(96, 260);
            this.Temps.Name = "Temps";
            this.Temps.Size = new System.Drawing.Size(396, 23);
            this.Temps.TabIndex = 9;
            // 
            // MinTemperatureValue
            // 
            this.MinTemperatureValue.Location = new System.Drawing.Point(66, 170);
            this.MinTemperatureValue.Name = "MinTemperatureValue";
            this.MinTemperatureValue.Size = new System.Drawing.Size(78, 23);
            this.MinTemperatureValue.TabIndex = 10;
            // 
            // MinTimeValue
            // 
            this.MinTimeValue.Location = new System.Drawing.Point(166, 173);
            this.MinTimeValue.Name = "MinTimeValue";
            this.MinTimeValue.Size = new System.Drawing.Size(64, 23);
            this.MinTimeValue.TabIndex = 11;
            // 
            // MaxTimeValue
            // 
            this.MaxTimeValue.Location = new System.Drawing.Point(166, 134);
            this.MaxTimeValue.Name = "MaxTimeValue";
            this.MaxTimeValue.Size = new System.Drawing.Size(64, 23);
            this.MaxTimeValue.TabIndex = 12;
            // 
            // MaxTemperatureValue
            // 
            this.MaxTemperatureValue.Location = new System.Drawing.Point(66, 134);
            this.MaxTemperatureValue.Name = "MaxTemperatureValue";
            this.MaxTemperatureValue.Size = new System.Drawing.Size(78, 23);
            this.MaxTemperatureValue.TabIndex = 13;
            // 
            // TakeReport
            // 
            this.TakeReport.Location = new System.Drawing.Point(287, 311);
            this.TakeReport.Name = "TakeReport";
            this.TakeReport.Size = new System.Drawing.Size(192, 77);
            this.TakeReport.TabIndex = 15;
            this.TakeReport.Text = "Получить отчет";
            this.TakeReport.UseVisualStyleBackColor = true;
            this.TakeReport.Click += new System.EventHandler(this.TakeReport_Click);
            // 
            // TimePicker
            // 
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(66, 213);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(200, 23);
            this.TimePicker.TabIndex = 16;
            // 
            // FishMerchendise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.TakeReport);
            this.Controls.Add(this.MaxTemperatureValue);
            this.Controls.Add(this.MaxTimeValue);
            this.Controls.Add(this.MinTimeValue);
            this.Controls.Add(this.MinTemperatureValue);
            this.Controls.Add(this.Temps);
            this.Controls.Add(this.TemperatureStack);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.MinTemperature);
            this.Controls.Add(this.MaxTemp);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Temperature);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.KindFish);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "FishMerchendise";
            this.Text = "GetFish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KindFish;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Temperature;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label MaxTemp;
        private System.Windows.Forms.Label MinTemperature;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label TemperatureStack;
        private System.Windows.Forms.TextBox Temps;
        private System.Windows.Forms.TextBox MinTemperatureValue;
        private System.Windows.Forms.TextBox MinTimeValue;
        private System.Windows.Forms.TextBox MaxTimeValue;
        private System.Windows.Forms.TextBox MaxTemperatureValue;
        private System.Windows.Forms.Button TakeReport;
        private System.Windows.Forms.DateTimePicker TimePicker;
    }
}

