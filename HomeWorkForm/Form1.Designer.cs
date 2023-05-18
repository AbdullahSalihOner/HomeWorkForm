namespace HomeWorkForm
{
    partial class Form1
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
            label1 = new Label();
            inputxtxtbox = new TextBox();
            hesaplabtn = new Button();
            factorialLbl = new Label();
            asalLbl = new Label();
            sayılarLbl = new Label();
            fctrlBtn = new Button();
            asalBtn = new Button();
            sayilarBtn = new Button();
            girilensayiLbl = new Label();
            sayiLbl = new Label();
            ErrorLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(103, 59);
            label1.Name = "label1";
            label1.Size = new Size(198, 41);
            label1.TabIndex = 0;
            label1.Text = "Sayı Giriniz :";
            // 
            // inputxtxtbox
            // 
            inputxtxtbox.Location = new Point(354, 69);
            inputxtxtbox.Name = "inputxtxtbox";
            inputxtxtbox.Size = new Size(208, 27);
            inputxtxtbox.TabIndex = 3;
            // 
            // hesaplabtn
            // 
            hesaplabtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hesaplabtn.Location = new Point(595, 59);
            hesaplabtn.Name = "hesaplabtn";
            hesaplabtn.Size = new Size(174, 41);
            hesaplabtn.TabIndex = 4;
            hesaplabtn.Text = "Hepsini Hesapla";
            hesaplabtn.UseVisualStyleBackColor = true;
            hesaplabtn.Click += hesaplabtn_Click;
            // 
            // factorialLbl
            // 
            factorialLbl.AutoSize = true;
            factorialLbl.BackColor = Color.MistyRose;
            factorialLbl.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            factorialLbl.Location = new Point(398, 208);
            factorialLbl.Name = "factorialLbl";
            factorialLbl.Size = new Size(164, 31);
            factorialLbl.TabIndex = 2;
            factorialLbl.Text = "                         ";
            // 
            // asalLbl
            // 
            asalLbl.AutoSize = true;
            asalLbl.BackColor = Color.MistyRose;
            asalLbl.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            asalLbl.Location = new Point(398, 304);
            asalLbl.Name = "asalLbl";
            asalLbl.Size = new Size(164, 31);
            asalLbl.TabIndex = 2;
            asalLbl.Text = "                         ";
            // 
            // sayılarLbl
            // 
            sayılarLbl.AutoSize = true;
            sayılarLbl.BackColor = Color.MistyRose;
            sayılarLbl.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            sayılarLbl.Location = new Point(398, 390);
            sayılarLbl.Name = "sayılarLbl";
            sayılarLbl.Size = new Size(164, 31);
            sayılarLbl.TabIndex = 2;
            sayılarLbl.Text = "                         ";
            // 
            // fctrlBtn
            // 
            fctrlBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            fctrlBtn.Location = new Point(103, 198);
            fctrlBtn.Name = "fctrlBtn";
            fctrlBtn.Size = new Size(198, 47);
            fctrlBtn.TabIndex = 5;
            fctrlBtn.Text = "Faktöriyel :";
            fctrlBtn.UseVisualStyleBackColor = true;
            fctrlBtn.Click += fctrlBtn_Click;
            // 
            // asalBtn
            // 
            asalBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            asalBtn.Location = new Point(103, 293);
            asalBtn.Name = "asalBtn";
            asalBtn.Size = new Size(198, 48);
            asalBtn.TabIndex = 6;
            asalBtn.Text = "Asal Sayı Mı ?";
            asalBtn.UseVisualStyleBackColor = true;
            asalBtn.Click += asalBtn_Click;
            // 
            // sayilarBtn
            // 
            sayilarBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            sayilarBtn.Location = new Point(103, 370);
            sayilarBtn.Name = "sayilarBtn";
            sayilarBtn.Size = new Size(198, 73);
            sayilarBtn.TabIndex = 7;
            sayilarBtn.Text = "Kendisine Kadar Olan Sayılar :";
            sayilarBtn.UseVisualStyleBackColor = true;
            sayilarBtn.Click += sayilarBtn_Click;
            // 
            // girilensayiLbl
            // 
            girilensayiLbl.AutoSize = true;
            girilensayiLbl.BackColor = SystemColors.Desktop;
            girilensayiLbl.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            girilensayiLbl.Location = new Point(113, 138);
            girilensayiLbl.Name = "girilensayiLbl";
            girilensayiLbl.Size = new Size(188, 31);
            girilensayiLbl.TabIndex = 8;
            girilensayiLbl.Text = "Girdiğiniz Sayı :";
            // 
            // sayiLbl
            // 
            sayiLbl.AutoSize = true;
            sayiLbl.BackColor = SystemColors.MenuHighlight;
            sayiLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            sayiLbl.Location = new Point(458, 138);
            sayiLbl.Name = "sayiLbl";
            sayiLbl.Size = new Size(104, 31);
            sayiLbl.TabIndex = 9;
            sayiLbl.Text = "               ";
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.BackColor = Color.Yellow;
            ErrorLabel.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            ErrorLabel.Location = new Point(239, 470);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(323, 38);
            ErrorLabel.TabIndex = 10;
            ErrorLabel.Text = "                                  ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.IndianRed;
            ClientSize = new Size(791, 517);
            Controls.Add(ErrorLabel);
            Controls.Add(sayiLbl);
            Controls.Add(girilensayiLbl);
            Controls.Add(sayilarBtn);
            Controls.Add(asalBtn);
            Controls.Add(fctrlBtn);
            Controls.Add(hesaplabtn);
            Controls.Add(inputxtxtbox);
            Controls.Add(sayılarLbl);
            Controls.Add(asalLbl);
            Controls.Add(factorialLbl);
            Controls.Add(label1);
            Name = "Form1";
            Text = "FACTORIAL CALC";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private Label factorial_label;
        private TextBox inputxtxtbox;
        private Button hesaplabtn;
        private Label factorialLbl;
        private Label asalLbl;
        private Label sayılarLbl;
        private Label label5;
        private Label label8;
        private Label label9;
        private Button fctrlBtn;
        private Button asalBtn;
        private Button sayilarBtn;
        private Label girilensayiLbl;
        private Label sayiLbl;
        private Label ErrorLabel;
    }
}