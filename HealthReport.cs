using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthApp
{
    public class HealthReport
    {
        public string status { get; set; }

        public List<string> notes { get; set; } = new List<string>();

        public void setStatus(string status)
        {
            this.status = status;
        }

        public void setNotes(string note)
        {
            notes.Add(note);
        }

        public string getStatus()
        {
            return status;
        }

        public string getNotes()
        {
            string message = null;

            if (notes.Any())
                foreach (string note in notes)
                    message += "* " + note + "\n";
            else
                message = "Зауважень немає";

            return message;
        }
    }
}
