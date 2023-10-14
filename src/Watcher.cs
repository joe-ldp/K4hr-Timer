using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace K4hr_Timer.src
{
    public class RunFinishedEventArgs : EventArgs
    {
        public long retimed_igt { get; set; }
        public long runFinishedAt { get; set; }

        public RunFinishedEventArgs(long retimed_igt, long runFinishedAt)
        {
            this.retimed_igt = retimed_igt;
            this.runFinishedAt = runFinishedAt;
        }
    }

    internal class Watcher
    {
        public EventHandler<RunFinishedEventArgs>? runFinished;

        private readonly string path;
        private readonly FileSystemWatcher fsw;

        public Watcher()
        {
            path = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                "speedrunigt",
                "records");

            fsw = new FileSystemWatcher(path);
            fsw.EnableRaisingEvents = true;
            fsw.Created += Fsw_Created;
        }

        private void Fsw_Created(object sender, FileSystemEventArgs e)
        {
            string filePath = e.FullPath;
            if (filePath == null || !filePath.Contains(".json"))
                return;

            string fileContents;
            while (!IsFileReady(filePath))
            {
                // twiddle thumbs
            }
            using (StreamReader reader = new StreamReader(filePath))
            {
                fileContents = reader.ReadToEnd();
            }
            dynamic? record = JsonConvert.DeserializeObject(fileContents);
            if (record == null)
                return;
            if (record.retimed_igt == 0)
                return;

            runFinished?.Invoke(this, new RunFinishedEventArgs(record.retimed_igt.Value, record.date.Value));
        }

        private static bool IsFileReady(string filename)
        {
            try
            {
                using (FileStream inputStream = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.None))
                    return inputStream.Length > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
