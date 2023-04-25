namespace Jaguars_Tech_Support.Boundary
{
    partial class CustomerScreen
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
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            roundedButton1 = new GUIForJTS.RoundedButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.SetChildIndex(label1, 0);
            panel1.Controls.SetChildIndex(label2, 0);
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(899, 336);
            label7.Name = "label7";
            label7.Size = new Size(51, 21);
            label7.TabIndex = 20;
            label7.Text = "Status";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(648, 336);
            label6.Name = "label6";
            label6.Size = new Size(78, 21);
            label6.TabIndex = 19;
            label6.Text = "Technician";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(297, 336);
            label5.Name = "label5";
            label5.Size = new Size(59, 21);
            label5.TabIndex = 18;
            label5.Text = "Subject";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(138, 336);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 17;
            label4.Text = "Ticket#";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(984, 20);
            label2.Name = "label2";
            label2.Size = new Size(114, 30);
            label2.TabIndex = 1;
            label2.Text = "username";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(488, 237);
            label3.Name = "label3";
            label3.Size = new Size(212, 30);
            label3.TabIndex = 21;
            label3.Text = "My Submitted Tickets";
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.Black;
            roundedButton1.BackgroundColor = Color.Black;
            roundedButton1.BorderColor = Color.PaleVioletRed;
            roundedButton1.BorderRadius = 40;
            roundedButton1.BorderSize = 0;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(89, 771);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(165, 40);
            roundedButton1.TabIndex = 22;
            roundedButton1.Text = "Start A New Request";
            roundedButton1.TextColor = Color.White;
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // CustomerScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1184, 861);
            Controls.Add(roundedButton1);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Name = "CustomerScreen";
            Text = "CustomerScreen";
            Load += CustomerScreen_Load;
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(roundedButton1, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private GUIForJTS.RoundedButton roundedButton1;
    }
}