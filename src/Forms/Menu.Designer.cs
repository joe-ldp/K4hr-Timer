namespace K4hr_Timer
{
    partial class Menu
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
            //btnOverlayColour = new Button();
            colorDialog1 = new ColorDialog();
            btnReset = new Button();
            gbAttempt = new GroupBox();
            lblAvgTimeNeeded = new Label();
            panelRuns = new Panel();
            lblTxtTimeRemaining = new Label();
            lblTimeLeft = new Label();
            numHours = new NumericUpDown();
            label2 = new Label();
            gbSettings = new GroupBox();
            numDesiredRuns = new NumericUpDown();
            label1 = new Label();
            gbAttempt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numHours).BeginInit();
            gbSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDesiredRuns).BeginInit();
            SuspendLayout();
            // 
            // btnOverlayColour
            // 
            //btnOverlayColour.Location = new Point(114, 22);
            //btnOverlayColour.Name = "btnOverlayColour";
            //btnOverlayColour.Size = new Size(145, 28);
            //btnOverlayColour.TabIndex = 0;
            //btnOverlayColour.Text = "Set green screen colour";
            //btnOverlayColour.UseVisualStyleBackColor = true;
            //btnOverlayColour.Click += btnOverlayColour_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(6, 22);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(102, 28);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset Attempt";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // gbAttempt
            // 
            gbAttempt.Controls.Add(lblAvgTimeNeeded);
            gbAttempt.Controls.Add(panelRuns);
            gbAttempt.Controls.Add(lblTxtTimeRemaining);
            gbAttempt.Controls.Add(lblTimeLeft);
            gbAttempt.Location = new Point(12, 118);
            gbAttempt.Name = "gbAttempt";
            gbAttempt.Size = new Size(301, 320);
            gbAttempt.TabIndex = 2;
            gbAttempt.TabStop = false;
            gbAttempt.Text = "Current Attempt";
            // 
            // lblAvgTimeNeeded
            // 
            lblAvgTimeNeeded.AutoSize = true;
            lblAvgTimeNeeded.Font = new Font("Segoe UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblAvgTimeNeeded.Location = new Point(145, 19);
            lblAvgTimeNeeded.Name = "lblAvgTimeNeeded";
            lblAvgTimeNeeded.Size = new Size(0, 12);
            lblAvgTimeNeeded.TabIndex = 3;
            // 
            // panelRuns
            // 
            panelRuns.AutoScroll = true;
            panelRuns.Location = new Point(1, 37);
            panelRuns.Name = "panelRuns";
            panelRuns.Size = new Size(299, 282);
            panelRuns.TabIndex = 2;
            // 
            // lblTxtTimeRemaining
            // 
            lblTxtTimeRemaining.AutoSize = true;
            lblTxtTimeRemaining.Location = new Point(100, 19);
            lblTxtTimeRemaining.Name = "lblTxtTimeRemaining";
            lblTxtTimeRemaining.Size = new Size(43, 15);
            lblTxtTimeRemaining.TabIndex = 1;
            lblTxtTimeRemaining.Text = "4:00:00";
            // 
            // lblTimeLeft
            // 
            lblTimeLeft.AutoSize = true;
            lblTimeLeft.Location = new Point(6, 19);
            lblTimeLeft.Name = "lblTimeLeft";
            lblTimeLeft.Size = new Size(96, 15);
            lblTimeLeft.TabIndex = 0;
            lblTimeLeft.Text = "Time Remaining:";
            // 
            // numHours
            // 
            numHours.Location = new Point(6, 71);
            numHours.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numHours.Name = "numHours";
            numHours.ReadOnly = true;
            numHours.Size = new Size(39, 23);
            numHours.TabIndex = 3;
            numHours.Value = new decimal(new int[] { 4, 0, 0, 0 });
            numHours.ValueChanged += numHours_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 53);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Hours";
            // 
            // gbSettings
            // 
            gbSettings.Controls.Add(numDesiredRuns);
            gbSettings.Controls.Add(label1);
            gbSettings.Controls.Add(btnOverlayColour);
            gbSettings.Controls.Add(btnReset);
            gbSettings.Controls.Add(label2);
            gbSettings.Controls.Add(numHours);
            gbSettings.Location = new Point(12, 12);
            gbSettings.Name = "gbSettings";
            gbSettings.Size = new Size(301, 100);
            gbSettings.TabIndex = 5;
            gbSettings.TabStop = false;
            gbSettings.Text = "Settings";
            // 
            // numDesiredRuns
            // 
            numDesiredRuns.Location = new Point(51, 71);
            numDesiredRuns.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDesiredRuns.Name = "numDesiredRuns";
            numDesiredRuns.ReadOnly = true;
            numDesiredRuns.Size = new Size(51, 23);
            numDesiredRuns.TabIndex = 6;
            numDesiredRuns.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numDesiredRuns.ValueChanged += numDesiredRuns_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 53);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 5;
            label1.Text = "Aiming for runs";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 450);
            Controls.Add(gbSettings);
            Controls.Add(gbAttempt);
            Name = "Menu";
            Text = "K4hr Timer - Menu";
            Load += Menu_Load;
            gbAttempt.ResumeLayout(false);
            gbAttempt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numHours).EndInit();
            gbSettings.ResumeLayout(false);
            gbSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDesiredRuns).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnOverlayColour;
        private ColorDialog colorDialog1;
        private Button btnReset;
        private GroupBox gbAttempt;
        private Label lblTxtTimeRemaining;
        private Label lblTimeLeft;
        private NumericUpDown numHours;
        private Label label2;
        private GroupBox gbSettings;
        private NumericUpDown numDesiredRuns;
        private Label label1;
        private Panel panelRuns;
        private Label lblAvgTimeNeeded;
    }
}