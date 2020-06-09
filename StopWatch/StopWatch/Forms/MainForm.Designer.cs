namespace StopWatch
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.tb_times = new System.Windows.Forms.TextBox();
            this.TimerC = new System.Windows.Forms.Timer(this.components);
            this.btn_sec = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_hr = new System.Windows.Forms.Button();
            this.btn_day = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btn_Start.FlatAppearance.BorderSize = 0;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(75, 130);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(350, 100);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btn_Stop.FlatAppearance.BorderSize = 0;
            this.btn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stop.Location = new System.Drawing.Point(75, 235);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(350, 100);
            this.btn_Stop.TabIndex = 1;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = false;
            this.btn_Stop.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btn_Reset.FlatAppearance.BorderSize = 0;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(75, 340);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(350, 100);
            this.btn_Reset.TabIndex = 2;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.ButtonClick);
            // 
            // tb_times
            // 
            this.tb_times.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.tb_times.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_times.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_times.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_times.Location = new System.Drawing.Point(75, 50);
            this.tb_times.Name = "tb_times";
            this.tb_times.Size = new System.Drawing.Size(350, 38);
            this.tb_times.TabIndex = 3;
            this.tb_times.Text = "12312321";
            this.tb_times.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_times.Visible = false;
            // 
            // TimerC
            // 
            this.TimerC.Enabled = true;
            this.TimerC.Tick += new System.EventHandler(this.timerTick);
            // 
            // btn_sec
            // 
            this.btn_sec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btn_sec.FlatAppearance.BorderSize = 0;
            this.btn_sec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sec.Location = new System.Drawing.Point(12, 130);
            this.btn_sec.Name = "btn_sec";
            this.btn_sec.Size = new System.Drawing.Size(47, 47);
            this.btn_sec.TabIndex = 4;
            this.btn_sec.Text = "Sec";
            this.btn_sec.UseVisualStyleBackColor = false;
            this.btn_sec.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_min.Location = new System.Drawing.Point(12, 183);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(47, 47);
            this.btn_min.TabIndex = 5;
            this.btn_min.Text = "Min";
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn_hr
            // 
            this.btn_hr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btn_hr.FlatAppearance.BorderSize = 0;
            this.btn_hr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hr.Location = new System.Drawing.Point(12, 235);
            this.btn_hr.Name = "btn_hr";
            this.btn_hr.Size = new System.Drawing.Size(47, 47);
            this.btn_hr.TabIndex = 6;
            this.btn_hr.Text = "Hr";
            this.btn_hr.UseVisualStyleBackColor = false;
            this.btn_hr.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn_day
            // 
            this.btn_day.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btn_day.FlatAppearance.BorderSize = 0;
            this.btn_day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_day.Location = new System.Drawing.Point(12, 288);
            this.btn_day.Name = "btn_day";
            this.btn_day.Size = new System.Drawing.Size(47, 47);
            this.btn_day.TabIndex = 7;
            this.btn_day.Text = "Day";
            this.btn_day.UseVisualStyleBackColor = false;
            this.btn_day.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.btn_day);
            this.Controls.Add(this.btn_hr);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_sec);
            this.Controls.Add(this.tb_times);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Stopwatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.TextBox tb_times;
        private System.Windows.Forms.Timer TimerC;
        private System.Windows.Forms.Button btn_sec;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_hr;
        private System.Windows.Forms.Button btn_day;
    }
}

