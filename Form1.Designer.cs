namespace UtasszallitoGUI
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
            label2 = new Label();
            tBxTorlonyomas = new TextBox();
            tBxStatikusnyomas = new TextBox();
            rtxEredmenyek = new RichTextBox();
            label3 = new Label();
            btnSzamol = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 20);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Torlónyomás:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 50);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 1;
            label2.Text = "Statikus nyomás";
            // 
            // tBxTorlonyomas
            // 
            tBxTorlonyomas.Location = new Point(118, 12);
            tBxTorlonyomas.Name = "tBxTorlonyomas";
            tBxTorlonyomas.Size = new Size(100, 23);
            tBxTorlonyomas.TabIndex = 2;
            // 
            // tBxStatikusnyomas
            // 
            tBxStatikusnyomas.Location = new Point(118, 42);
            tBxStatikusnyomas.Name = "tBxStatikusnyomas";
            tBxStatikusnyomas.Size = new Size(100, 23);
            tBxStatikusnyomas.TabIndex = 3;
            // 
            // rtxEredmenyek
            // 
            rtxEredmenyek.BorderStyle = BorderStyle.None;
            rtxEredmenyek.Location = new Point(23, 117);
            rtxEredmenyek.Name = "rtxEredmenyek";
            rtxEredmenyek.Size = new Size(291, 298);
            rtxEredmenyek.TabIndex = 4;
            rtxEredmenyek.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 90);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 5;
            label3.Text = "Eredmények:";
            // 
            // btnSzamol
            // 
            btnSzamol.Location = new Point(239, 12);
            btnSzamol.Name = "btnSzamol";
            btnSzamol.Size = new Size(75, 53);
            btnSzamol.TabIndex = 6;
            btnSzamol.Text = "Számol";
            btnSzamol.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 427);
            Controls.Add(btnSzamol);
            Controls.Add(label3);
            Controls.Add(rtxEredmenyek);
            Controls.Add(tBxStatikusnyomas);
            Controls.Add(tBxTorlonyomas);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(348, 466);
            MinimumSize = new Size(348, 466);
            Name = "Form1";
            Text = "Mach-szám kalkulátor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tBxTorlonyomas;
        private TextBox tBxStatikusnyomas;
        private RichTextBox rtxEredmenyek;
        private Label label3;
        private Button btnSzamol;
    }
}
