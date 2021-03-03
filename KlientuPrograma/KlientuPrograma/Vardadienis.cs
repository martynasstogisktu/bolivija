using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlientuPrograma
{
    class Vardadienis
    {
        DateTime data;
        List<string> vardai;

        public Vardadienis(DateTime data, List<string> vardai)
        {
            this.data = data;
            this.vardai = vardai;
        }

        public DateTime GetDate()
        { return data; }

        public List<string> GetNames()
        { return vardai; }

        public override string ToString()
        {
            string line = string.Format("{0, 2} {1, 2} ", data.Month, data.Day);
            foreach (string name in vardai)
            {
                line += name + " ";
            }
            return line;
        }
    }
}
