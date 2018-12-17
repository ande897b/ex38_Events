using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex38_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Metronome_ met = new Metronome_();
            TickListener listener = new TickListener();
            listener.Attach(met);
            met.Start();

        }
    }
}
