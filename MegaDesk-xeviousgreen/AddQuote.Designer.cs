namespace MegaDesk_xeviousgreen
{
    partial class AddQuote
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
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.drawsDown = new System.Windows.Forms.NumericUpDown();
            this.depthDown = new System.Windows.Forms.NumericUpDown();
            this.widthDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalCalc = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.Label();
            this.timeDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.matDown = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawsDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(581, 375);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 0;
            this.Back.Text = "Main Menu";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Desk Width";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Delivery (14 days default)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(403, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Desktop Material";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Number of Drawers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Desk Depth";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 16;
            // 
            // drawsDown
            // 
            this.drawsDown.Location = new System.Drawing.Point(261, 193);
            this.drawsDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawsDown.Name = "drawsDown";
            this.drawsDown.Size = new System.Drawing.Size(120, 20);
            this.drawsDown.TabIndex = 19;
            // 
            // depthDown
            // 
            this.depthDown.Location = new System.Drawing.Point(262, 152);
            this.depthDown.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthDown.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthDown.Name = "depthDown";
            this.depthDown.Size = new System.Drawing.Size(120, 20);
            this.depthDown.TabIndex = 20;
            this.depthDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // widthDown
            // 
            this.widthDown.Location = new System.Drawing.Point(262, 116);
            this.widthDown.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthDown.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthDown.Name = "widthDown";
            this.widthDown.Size = new System.Drawing.Size(120, 20);
            this.widthDown.TabIndex = 21;
            this.widthDown.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 22);
            this.label7.TabIndex = 22;
            this.label7.Text = "Total Amount";
            // 
            // TotalCalc
            // 
            this.TotalCalc.Location = new System.Drawing.Point(67, 374);
            this.TotalCalc.Name = "TotalCalc";
            this.TotalCalc.Size = new System.Drawing.Size(75, 23);
            this.TotalCalc.TabIndex = 24;
            this.TotalCalc.Text = "Calculate ";
            this.TotalCalc.UseVisualStyleBackColor = true;
            this.TotalCalc.Click += new System.EventHandler(this.TotalCalc_Click);
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(240, 327);
            this.amount.MinimumSize = new System.Drawing.Size(121, 21);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(121, 22);
            this.amount.TabIndex = 25;
            this.amount.Click += new System.EventHandler(this.label8_Click);
            this.amount.Validated += new System.EventHandler(this.TotalCalc_Click);
            // 
            // timeDown
            // 
            this.timeDown.Location = new System.Drawing.Point(262, 274);
            this.timeDown.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.timeDown.Name = "timeDown";
            this.timeDown.Size = new System.Drawing.Size(120, 20);
            this.timeDown.TabIndex = 26;
            this.timeDown.ValueChanged += new System.EventHandler(this.timeDown_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(427, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Oak=1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(550, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Laminate=2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(426, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Pine=3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(425, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Veneer=5";
            // 
            // matDown
            // 
            this.matDown.Location = new System.Drawing.Point(553, 119);
            this.matDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.matDown.Name = "matDown";
            this.matDown.Size = new System.Drawing.Size(120, 20);
            this.matDown.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(550, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Rosewood=4";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.matDown);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.timeDown);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.TotalCalc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.widthDown);
            this.Controls.Add(this.depthDown);
            this.Controls.Add(this.drawsDown);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Name = "AddQuote";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.drawsDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown drawsDown;
        private System.Windows.Forms.NumericUpDown depthDown;
        private System.Windows.Forms.NumericUpDown widthDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button TotalCalc;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.NumericUpDown timeDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown matDown;
        private System.Windows.Forms.Label label12;
    }
}