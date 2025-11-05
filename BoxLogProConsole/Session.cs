using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxLogProConsole
{
    public class Session
    {
        public DateTime Date { get; set; }
        public List<ExerciseLog> ExerciseLogs { get; set; } = new List<ExerciseLog>();

        public override string ToString()
        {
            string summary = $"Session on {Date.ToShortDateString()}:\n";
            foreach (var log in ExerciseLogs)
            {
                summary += $"- {log.Exercise.Name}: {log.DurationMinutes} min — {log.Notes}\n";
            }
            return summary;
        }
    }
}
