namespace WindowsFormsyTestApp.Forms
{
    partial class InfoTransportForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AmoutOfCarNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AVGNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.totalPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AmoutOfCarNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AVGNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPriceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(201, 99);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кол-во машин";
            // 
            // AmoutOfCarNumericUpDown
            // 
            this.AmoutOfCarNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.AmoutOfCarNumericUpDown.Location = new System.Drawing.Point(201, 125);
            this.AmoutOfCarNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.AmoutOfCarNumericUpDown.Name = "AmoutOfCarNumericUpDown";
            this.AmoutOfCarNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.AmoutOfCarNumericUpDown.TabIndex = 5;
            // 
            // AVGNumericUpDown
            // 
            this.AVGNumericUpDown.Location = new System.Drawing.Point(201, 151);
            this.AVGNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.AVGNumericUpDown.Name = "AVGNumericUpDown";
            this.AVGNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.AVGNumericUpDown.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Средняя скорость";
            // 
            // totalPriceNumericUpDown
            // 
            this.totalPriceNumericUpDown.Location = new System.Drawing.Point(201, 177);
            this.totalPriceNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.totalPriceNumericUpDown.Name = "totalPriceNumericUpDown";
            this.totalPriceNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.totalPriceNumericUpDown.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Стоимость проезда";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(74, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(226, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InfoTransportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 348);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.totalPriceNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AVGNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AmoutOfCarNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "InfoTransportForm";
            this.Text = "Транспорт";
            ((System.ComponentModel.ISupportInitialize)(this.AmoutOfCarNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AVGNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPriceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown AmoutOfCarNumericUpDown;
        private System.Windows.Forms.NumericUpDown AVGNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown totalPriceNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}