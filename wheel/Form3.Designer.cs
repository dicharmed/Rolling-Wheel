namespace wheel
{
    partial class Form3
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
            this.Label1 = new System.Windows.Forms.Label();
            this.CommandStop = new System.Windows.Forms.Button();
            this.CommandStart = new System.Windows.Forms.Button();
            this.CommandInit = new System.Windows.Forms.Button();
            this.TextFiMax = new System.Windows.Forms.TextBox();
            this.TextDeltaFi = new System.Windows.Forms.TextBox();
            this.TexTR = new System.Windows.Forms.TextBox();
            this.TextR1 = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Axis2 = new myUCLib.Axis();
            this.Axis1 = new myUCLib.Axis();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(1, 26);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(21, 13);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "R1";
            // 
            // CommandStop
            // 
            this.CommandStop.Location = new System.Drawing.Point(477, 0);
            this.CommandStop.Name = "CommandStop";
            this.CommandStop.Size = new System.Drawing.Size(47, 23);
            this.CommandStop.TabIndex = 10;
            this.CommandStop.Text = "Стоп";
            this.CommandStop.UseVisualStyleBackColor = true;
            this.CommandStop.Click += new System.EventHandler(this.CommandStop_Click);
            // 
            // CommandStart
            // 
            this.CommandStart.Enabled = false;
            this.CommandStart.Location = new System.Drawing.Point(427, 0);
            this.CommandStart.Name = "CommandStart";
            this.CommandStart.Size = new System.Drawing.Size(44, 23);
            this.CommandStart.TabIndex = 9;
            this.CommandStart.Text = "Старт";
            this.CommandStart.UseVisualStyleBackColor = true;
            this.CommandStart.Click += new System.EventHandler(this.CommandStart_Click);
            // 
            // CommandInit
            // 
            this.CommandInit.Location = new System.Drawing.Point(346, 0);
            this.CommandInit.Name = "CommandInit";
            this.CommandInit.Size = new System.Drawing.Size(75, 23);
            this.CommandInit.TabIndex = 8;
            this.CommandInit.Text = "Данные";
            this.CommandInit.UseVisualStyleBackColor = true;
            this.CommandInit.Click += new System.EventHandler(this.CommandInit_Click);
            // 
            // TextFiMax
            // 
            this.TextFiMax.Location = new System.Drawing.Point(287, 0);
            this.TextFiMax.Name = "TextFiMax";
            this.TextFiMax.Size = new System.Drawing.Size(53, 20);
            this.TextFiMax.TabIndex = 7;
            this.TextFiMax.Text = "100";
            // 
            // TextDeltaFi
            // 
            this.TextDeltaFi.Location = new System.Drawing.Point(196, 0);
            this.TextDeltaFi.Name = "TextDeltaFi";
            this.TextDeltaFi.Size = new System.Drawing.Size(45, 20);
            this.TextDeltaFi.TabIndex = 6;
            this.TextDeltaFi.Text = "0.1";
            // 
            // TexTR
            // 
            this.TexTR.Location = new System.Drawing.Point(97, 0);
            this.TexTR.Name = "TexTR";
            this.TexTR.Size = new System.Drawing.Size(47, 20);
            this.TexTR.TabIndex = 5;
            this.TexTR.Text = "1";
            // 
            // TextR1
            // 
            this.TextR1.Location = new System.Drawing.Point(24, 0);
            this.TextR1.Name = "TextR1";
            this.TextR1.Size = new System.Drawing.Size(46, 20);
            this.TextR1.TabIndex = 4;
            this.TextR1.Text = "2";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(247, 3);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(34, 13);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Fimax";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(150, 3);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(40, 13);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "DeltaFi";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(76, 5);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(15, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "R";
            // 
            // Axis2
            // 
            this.Axis2.axis_bkcolor = System.Drawing.Color.White;
            this.Axis2.axis_color = System.Drawing.Color.Gray;
            this.Axis2.Axis_Type = ((byte)(1));
            this.Axis2.E_x = 0;
            this.Axis2.E_y = 0;
            this.Axis2.Location = new System.Drawing.Point(268, 50);
            this.Axis2.Name = "Axis2";
            this.Axis2.Pix_color = System.Drawing.Color.Black;
            this.Axis2.Pix_Size = 1F;
            this.Axis2.Pix_type = ((byte)(1));
            this.Axis2.Size = new System.Drawing.Size(250, 241);
            this.Axis2.TabIndex = 16;
            this.Axis2.x_Base = 1F;
            this.Axis2.x_Name = "X";
            this.Axis2.y_Base = 1F;
            this.Axis2.y_Name = "Y";
            // 
            // Axis1
            // 
            this.Axis1.axis_bkcolor = System.Drawing.Color.White;
            this.Axis1.axis_color = System.Drawing.Color.Gray;
            this.Axis1.Axis_Type = ((byte)(1));
            this.Axis1.E_x = 0;
            this.Axis1.E_y = 0;
            this.Axis1.Location = new System.Drawing.Point(10, 50);
            this.Axis1.Name = "Axis1";
            this.Axis1.Pix_color = System.Drawing.Color.Black;
            this.Axis1.Pix_Size = 1F;
            this.Axis1.Pix_type = ((byte)(1));
            this.Axis1.Size = new System.Drawing.Size(241, 243);
            this.Axis1.TabIndex = 15;
            this.Axis1.x_Base = 1F;
            this.Axis1.x_Name = "X";
            this.Axis1.y_Base = 1F;
            this.Axis1.y_Name = "Y";
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.CommandStop);
            this.GroupBox1.Controls.Add(this.CommandStart);
            this.GroupBox1.Controls.Add(this.CommandInit);
            this.GroupBox1.Controls.Add(this.TextFiMax);
            this.GroupBox1.Controls.Add(this.TextDeltaFi);
            this.GroupBox1.Controls.Add(this.TexTR);
            this.GroupBox1.Controls.Add(this.TextR1);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Location = new System.Drawing.Point(4, 21);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(527, 25);
            this.GroupBox1.TabIndex = 17;
            this.GroupBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 315);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Axis2);
            this.Controls.Add(this.Axis1);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Form3";
            this.Text = "Эпициклоиды";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Resize += new System.EventHandler(this.Form3_Resize);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button CommandStop;
        internal System.Windows.Forms.Button CommandStart;
        internal System.Windows.Forms.Button CommandInit;
        internal System.Windows.Forms.TextBox TextFiMax;
        internal System.Windows.Forms.TextBox TextDeltaFi;
        internal System.Windows.Forms.TextBox TexTR;
        internal System.Windows.Forms.TextBox TextR1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal myUCLib.Axis Axis2;
        internal myUCLib.Axis Axis1;
        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.GroupBox GroupBox1;
    }
}