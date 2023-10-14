using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace K4hr_Timer.src.Classes
{
    internal class Attempt
    {
        public EventHandler? attemptFinished;

        DateTime startedAt;
        DateTime finishesAt;
        List<Run> runs;
        System.Timers.Timer attemptTimer;
        public int desiredRuns;

        public Attempt(int hours, int attemptsToBeat, TimeSpan startOffset)
        {
            startedAt = DateTime.Now.Subtract(startOffset);
            finishesAt = DateTime.Now + TimeSpan.FromHours(hours);
            runs = new List<Run>();
            attemptTimer = new System.Timers.Timer();
            attemptTimer.Interval = hours * 60 * 60 * 1000;
            attemptTimer.Elapsed += AttemptTimer_Elapsed;
            this.desiredRuns = attemptsToBeat;
        }

        private void AttemptTimer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            attemptFinished?.Invoke(this, new EventArgs());
        }

        public void AddRun(Run run)
        {
            runs.Add(run);
        }

        public TimeSpan averageTimeNeeded()
        {
            if (runs.Count >= desiredRuns)
                return TimeSpan.Zero;
            return timeRemaining() / (desiredRuns - runs.Count);
        }

        public TimeSpan timeRemaining()
        {
            return finishesAt.Subtract(DateTime.Now);
        }

        public int NumCompletedRuns()
        {
            return runs.Count;
        }

        public TimeSpan CurrentTime()
        {
            return DateTime.Now.Subtract(startedAt);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Time Remaining: {0} ({1} avg RTA needed)",
                timeRemaining().ToString(@"hh\:mm\:ss"), averageTimeNeeded().ToString(@"hh\:mm\:ss")));
            foreach (Run run in runs)
            {
                sb.AppendLine(run.ToString());
            }
            return sb.ToString();
        }
    }
}
