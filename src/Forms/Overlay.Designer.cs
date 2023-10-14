namespace K4hr_Timer
{
    partial class Overlay
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
            panelRuns = new Panel();
            SuspendLayout();
            // 
            // panelRuns
            // 
            panelRuns.Location = new Point(0, 0);
            panelRuns.Name = "panelRuns";
            panelRuns.Size = new Size(326, 361);
            panelRuns.TabIndex = 3;
            // 
            // Overlay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(326, 361);
            Controls.Add(panelRuns);
            Name = "Overlay";
            Text = "K4hr Timer - Overlay";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelRuns;
    }
}