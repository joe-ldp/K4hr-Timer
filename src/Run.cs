using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace K4hr_Timer
{
    internal class Run
    {
        public TimeSpan completionRTT;
        public TimeSpan completedAt;
        public int runNumber;

        public Run(int runNumber, TimeSpan completionRTT, TimeSpan completedAt)
        {
            this.runNumber = runNumber;
            this.completionRTT = completionRTT;
            this.completedAt = completedAt;
        }

        public override string ToString()
        {
            return string.Format("Run {0} completed at {1} with {2} IGT",
                runNumber,
                completedAt.ToString(@"hh\:mm\:ss"),
                completionRTT.ToString(@"hh\:mm\:ss"));
        }
    }
}
