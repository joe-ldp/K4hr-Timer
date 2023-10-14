using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using K4hr_Timer.src.Classes;

namespace K4hr_Timer
{
    public partial class Menu : Form
    {
        Watcher watcher;
        //Overlay overlay;
        Attempt? currAtt;
        System.Timers.Timer countdownTick;
        string outputFile;

        public Menu()
        {
            InitializeComponent();
            //overlay = new Overlay();
            //overlay.BackColor = Color.FromArgb(0, 170, 0);

            watcher = new Watcher();
            watcher.runFinished += runFinished;

            countdownTick = new System.Timers.Timer();
            countdownTick.Interval = 1000;
            countdownTick.AutoReset = true;
            countdownTick.Elapsed += CountdownTick_Tick;
            outputFile = "currentAttempt.txt";
            if (!File.Exists(outputFile))
                File.WriteAllText(outputFile, "");
        }

        private void CountdownTick_Tick(object? sender, EventArgs e)
        {
            if (currAtt != null)
            {
                TimeSpan hours = TimeSpan.FromHours((int)numHours.Value);
                CrossThreadExtensions.PerformSafely(this, () =>
                    lblTxtTimeRemaining.Text = hours.Subtract(currAtt.CurrentTime()).ToString(@"hh\:mm\:ss"));
                CrossThreadExtensions.PerformSafely(this, () => lblTxtTimeRemaining.Refresh());
            }
        }

        private void ResetCountdown()
        {
            lblTxtTimeRemaining.Text = TimeSpan.FromHours((int)numHours.Value).ToString(@"hh\:mm\:ss");
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //overlay.Show();
        }

        //private void btnOverlayColour_Click(object sender, EventArgs e)
        //{
        //    ColorDialog dialog = new ColorDialog();
        //    dialog.AllowFullOpen = false;
        //    dialog.Color = overlay.BackColor;

        //    if (dialog.ShowDialog() == DialogResult.OK)
        //    {
        //        overlay.BackColor = dialog.Color;
        //    }
        //}

        private void btnReset_Click(object sender, EventArgs e)
        {
            currAtt = null;
            countdownTick.Stop();
            ResetCountdown();
            panelRuns.Controls.Clear();
            lblAvgTimeNeeded.Text = "";
            File.WriteAllText(outputFile, "");
        }

        private void runFinished(object sender, RunFinishedEventArgs e)
        {
            if (currAtt == null)
            {
                currAtt = new Attempt((int)numHours.Value, (int)numDesiredRuns.Value, TimeSpan.FromMilliseconds(e.retimed_igt));
                countdownTick.Start();
            }

            Run run = new Run(
                currAtt.NumCompletedRuns()+1,
                TimeSpan.FromMilliseconds(e.retimed_igt),
                currAtt.CurrentTime());

            currAtt.AddRun(run);

            File.WriteAllText(outputFile, currAtt.ToString());

            Label lbl = new Label
            {
                Name = string.Format("lblRun{0}", currAtt.NumCompletedRuns()),
                Text = run.ToString(),
                Location = new Point(panelRuns.Left + 5, (currAtt.NumCompletedRuns() - 1) * 20),
                AutoSize = true,
            };
            lbl.Refresh();
            CrossThreadExtensions.PerformSafely(this, () => panelRuns.Controls.Add(lbl));
            //CrossThreadExtensions.PerformSafely(this, () => lbl.Anchor = AnchorStyles.Top);

            CrossThreadExtensions.PerformSafely(this, () => UpdateTimeNeeded());
        }

        private void attemptFinished(object sender, EventArgs e)
        {
            ActiveForm.Controls.Add(new TextBox());
        }

        private void UpdateTimeNeeded()
        {
            if (currAtt != null)
            {
                if (currAtt.NumCompletedRuns() >= numDesiredRuns.Value)
                {
                    lblAvgTimeNeeded.Visible = false;
                    return;
                }
                lblAvgTimeNeeded.Text = string.Format("(Average time needed: {0})", currAtt.averageTimeNeeded().ToString(@"mm\:ss"));
            }
        }

        private void numDesiredRuns_ValueChanged(object sender, EventArgs e)
        {
            UpdateTimeNeeded();
            if (currAtt != null)
            {
                currAtt.desiredRuns = (int)numDesiredRuns.Value;
            }
        }

        private void numHours_ValueChanged(object sender, EventArgs e)
        {
            ResetCountdown();
        }
    }
}