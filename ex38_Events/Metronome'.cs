using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex38_Events
{
 
      
   public class Metronome_
    {
        public delegate void EventHandler(Metronome_ metronome, EventArgs events);
        public EventArgs events = null;
        TickListener listener = new TickListener();
        public event EventHandler Tick;

        public void Start()
        {
           

                for (int i = 0; i < 5; i++)
                {
                System.Threading.Thread.Sleep(3000);
                if (Tick != null)
                {
                    Tick(this, events);
                }
                    
                }
               
            
        }

       
        

        
    }
}
