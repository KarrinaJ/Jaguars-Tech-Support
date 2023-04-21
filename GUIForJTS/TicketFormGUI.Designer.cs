namespace GUIForJTS
{
    partial class TicketFormGUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            customTextBox1 = new CustomTextBox();
            customTextBox2 = new CustomTextBox();
            label4 = new Label();
            roundedButton1 = new RoundedButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(464, 53);
            label1.Name = "label1";
            label1.Size = new Size(181, 30);
            label1.TabIndex = 0;
            label1.Text = "Create New Ticket";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(342, 179);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 1;
            label2.Text = "Subject*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(342, 274);
            label3.Name = "label3";
            label3.Size = new Size(110, 21);
            label3.TabIndex = 2;
            label3.Text = "Describe Issue*";
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = Color.White;
            customTextBox1.BorderColor = Color.Black;
            customTextBox1.BorderFocusColor = Color.HotPink;
            customTextBox1.BorderRadius = 15;
            customTextBox1.BorderSize = 1;
            customTextBox1.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox1.ForeColor = Color.DimGray;
            customTextBox1.Location = new Point(342, 204);
            customTextBox1.Margin = new Padding(3, 4, 3, 4);
            customTextBox1.Multiline = false;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(11, 9, 11, 9);
            customTextBox1.PasswordChar = false;
            customTextBox1.Size = new Size(402, 40);
            customTextBox1.TabIndex = 3;
            customTextBox1.Texts = "";
            customTextBox1.UnderlinedSytle = false;
            // 
            // customTextBox2
            // 
            customTextBox2.BackColor = Color.White;
            customTextBox2.BorderColor = Color.Black;
            customTextBox2.BorderFocusColor = Color.HotPink;
            customTextBox2.BorderRadius = 15;
            customTextBox2.BorderSize = 1;
            customTextBox2.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox2.ForeColor = Color.DimGray;
            customTextBox2.Location = new Point(342, 299);
            customTextBox2.Margin = new Padding(3, 4, 3, 4);
            customTextBox2.Multiline = true;
            customTextBox2.Name = "customTextBox2";
            customTextBox2.Padding = new Padding(11, 9, 11, 9);
            customTextBox2.PasswordChar = false;
            customTextBox2.Size = new Size(413, 274);
            customTextBox2.TabIndex = 4;
            customTextBox2.Texts = "";
            customTextBox2.UnderlinedSytle = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(342, 577);
            label4.Name = "label4";
            label4.Size = new Size(97, 17);
            label4.TabIndex = 5;
            label4.Text = "Required Fields*";
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.Black;
            roundedButton1.BackgroundColor = Color.Black;
            roundedButton1.BorderColor = Color.PaleVioletRed;
            roundedButton1.BorderRadius = 30;
            roundedButton1.BorderSize = 0;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(342, 635);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(141, 34);
            roundedButton1.TabIndex = 6;
            roundedButton1.Text = "Submit Ticket";
            roundedButton1.TextColor = Color.White;
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // TicketFormGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(roundedButton1);
            Controls.Add(label4);
            Controls.Add(customTextBox2);
            Controls.Add(customTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TicketFormGUI";
            Size = new Size(1100, 720);
            Load += CreateTicketPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private CustomTextBox customTextBox1;
        private CustomTextBox customTextBox2;
        private Label label4;
        private RoundedButton roundedButton1;
    }
}
