namespace VisualSortingAlgorithm
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
            lblAlgorithm = new Label();
            cmbAlgorithm = new ComboBox();
            btnReset = new Button();
            panel1 = new Panel();
            btnStart = new Button();
            SuspendLayout();
            // 
            // lblAlgorithm
            // 
            lblAlgorithm.AutoSize = true;
            lblAlgorithm.Location = new Point(38, 39);
            lblAlgorithm.Name = "lblAlgorithm";
            lblAlgorithm.Size = new Size(76, 20);
            lblAlgorithm.TabIndex = 0;
            lblAlgorithm.Text = "Algorithm";
            // 
            // cmbAlgorithm
            // 
            cmbAlgorithm.FormattingEnabled = true;
            cmbAlgorithm.Location = new Point(150, 39);
            cmbAlgorithm.Name = "cmbAlgorithm";
            cmbAlgorithm.Size = new Size(151, 28);
            cmbAlgorithm.TabIndex = 1;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(360, 35);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(95, 35);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Location = new Point(38, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(861, 468);
            panel1.TabIndex = 3;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(499, 35);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 35);
            btnStart.TabIndex = 4;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 568);
            Controls.Add(btnStart);
            Controls.Add(panel1);
            Controls.Add(btnReset);
            Controls.Add(cmbAlgorithm);
            Controls.Add(lblAlgorithm);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAlgorithm;
        private ComboBox cmbAlgorithm;
        private Button btnReset;
        private Panel panel1;
        private Button btnStart;
    }
}
