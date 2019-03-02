namespace wheel
{
    partial class Сycloid
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
            this.Axis1 = new myUCLib.Axis();
            this.Axis2 = new myUCLib.Axis();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.CommandStop = new System.Windows.Forms.Button();
            this.CommandStart = new System.Windows.Forms.Button();
            this.CommandInit = new System.Windows.Forms.Button();
            this.TextLambdaA = new System.Windows.Forms.TextBox();
            this.TextDeltaFi = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Axis1
            // 
            this.Axis1.axis_bkcolor = System.Drawing.Color.White;
            this.Axis1.axis_color = System.Drawing.Color.Gray;
            this.Axis1.Axis_Type = ((byte)(1));
            this.Axis1.E_x = 0;
            this.Axis1.E_y = 0;
            this.Axis1.Location = new System.Drawing.Point(4, 3);
            this.Axis1.Name = "Axis1";
            this.Axis1.Pix_color = System.Drawing.Color.Black;
            this.Axis1.Pix_Size = 1F;
            this.Axis1.Pix_type = ((byte)(1));
            this.Axis1.Size = new System.Drawing.Size(478, 148);
            this.Axis1.TabIndex = 0;
            this.Axis1.x_Base = 1F;
            this.Axis1.x_Name = "X";
            this.Axis1.y_Base = 1F;
            this.Axis1.y_Name = "Y";
            // 
            // Axis2
            // 
            this.Axis2.axis_bkcolor = System.Drawing.Color.White;
            this.Axis2.axis_color = System.Drawing.Color.Gray;
            this.Axis2.Axis_Type = ((byte)(1));
            this.Axis2.E_x = 0;
            this.Axis2.E_y = 0;
            this.Axis2.Location = new System.Drawing.Point(2, 161);
            this.Axis2.Name = "Axis2";
            this.Axis2.Pix_color = System.Drawing.Color.Black;
            this.Axis2.Pix_Size = 1F;
            this.Axis2.Pix_type = ((byte)(1));
            this.Axis2.Size = new System.Drawing.Size(480, 148);
            this.Axis2.TabIndex = 1;
            this.Axis2.x_Base = 1F;
            this.Axis2.x_Name = "X";
            this.Axis2.y_Base = 1F;
            this.Axis2.y_Name = "Y";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.CommandStop);
            this.GroupBox1.Controls.Add(this.CommandStart);
            this.GroupBox1.Controls.Add(this.CommandInit);
            this.GroupBox1.Controls.Add(this.TextLambdaA);
            this.GroupBox1.Controls.Add(this.TextDeltaFi);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(501, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(135, 269);
            this.GroupBox1.TabIndex = 10;
            this.GroupBox1.TabStop = false;
            // 
            // CommandStop
            // 
            this.CommandStop.Location = new System.Drawing.Point(19, 219);
            this.CommandStop.Name = "CommandStop";
            this.CommandStop.Size = new System.Drawing.Size(100, 23);
            this.CommandStop.TabIndex = 8;
            this.CommandStop.Text = "Стоп";
            this.CommandStop.UseVisualStyleBackColor = true;
            this.CommandStop.Click += new System.EventHandler(this.CommandStop_Click);
            // 
            // CommandStart
            // 
            this.CommandStart.Enabled = false;
            this.CommandStart.Location = new System.Drawing.Point(19, 190);
            this.CommandStart.Name = "CommandStart";
            this.CommandStart.Size = new System.Drawing.Size(100, 23);
            this.CommandStart.TabIndex = 7;
            this.CommandStart.Text = "Старт";
            this.CommandStart.UseVisualStyleBackColor = true;
            this.CommandStart.Click += new System.EventHandler(this.CommandStart_Click);
            // 
            // CommandInit
            // 
            this.CommandInit.Location = new System.Drawing.Point(19, 161);
            this.CommandInit.Name = "CommandInit";
            this.CommandInit.Size = new System.Drawing.Size(100, 23);
            this.CommandInit.TabIndex = 6;
            this.CommandInit.Text = "Данные";
            this.CommandInit.UseVisualStyleBackColor = true;
            this.CommandInit.Click += new System.EventHandler(this.CommandInit_Click);
            // 
            // TextLambdaA
            // 
            this.TextLambdaA.Location = new System.Drawing.Point(19, 72);
            this.TextLambdaA.Name = "TextLambdaA";
            this.TextLambdaA.Size = new System.Drawing.Size(100, 20);
            this.TextLambdaA.TabIndex = 5;
            this.TextLambdaA.Text = "1";
            // 
            // TextDeltaFi
            // 
            this.TextDeltaFi.Location = new System.Drawing.Point(19, 25);
            this.TextDeltaFi.Name = "TextDeltaFi";
            this.TextDeltaFi.Size = new System.Drawing.Size(100, 20);
            this.TextDeltaFi.TabIndex = 4;
            this.TextDeltaFi.Text = "0.01";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(16, 47);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(45, 13);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Lambda";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(16, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "DeltaF1";
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 318);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Axis2);
            this.Controls.Add(this.Axis1);
            this.Name = "Form2";
            this.Text = "Катится колесо. Циклоиды";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button CommandStop;
        internal System.Windows.Forms.Button CommandStart;
        internal System.Windows.Forms.Button CommandInit;
        internal System.Windows.Forms.TextBox TextLambdaA;
        internal System.Windows.Forms.TextBox TextDeltaFi;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Timer Timer1;
        internal myUCLib.Axis Axis1;
        internal myUCLib.Axis Axis2;
    }
}