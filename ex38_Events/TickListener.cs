using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex38_Events
{
   public class TickListener
    {
      
        public void Attach(Metronome_ tis)
        {
            tis.Tick += new Metronome_.EventHandler(HeardYou);   
        }
        public void HeardYou(Metronome_ m, EventArgs e)
        {
            Console.WriteLine("heard you woman");
        }
    }
}
