using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoxLogProConsole;

namespace BoxLogProConsole
{
    public class SessionManager
    {
        private List<Session> sessions = new List<Session>();

        public void AddSession(Session session)
        {
            sessions.Add(session);
            Console.WriteLine("Session added successfully!\n");
        }

        public void ViewSessions()
        {
            if (sessions.Count == 0)
            {
                Console.WriteLine("No sessions logged yet.\n");
                return;
            }

            Console.WriteLine("📖 Your Boxing Sessions (sorted by date):");
            foreach (var session in sessions.OrderByDescending(s => s.Date))
            {
                Console.WriteLine(session);
            }
            Console.WriteLine();
        }
    }
}
