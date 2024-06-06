using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_19___Fasade_pattern
{
    public class HomeTheaterFacade
    {
        // Fields, her bruges composition
        private Amplifier amp;
        private CdPlayer cd;
        private DvdPlayer dvd;
        private PopcornPopper popper;
        private Projector projector;
        private Screen screen;
        private TheaterLights lights;

        public HomeTheaterFacade(Amplifier amp, CdPlayer cd, DvdPlayer dvd, PopcornPopper popper, Projector projector, Screen screen, TheaterLights lights)
        {
            this.amp = amp;
            this.cd = cd;
            this.dvd = dvd;
            this.popper = popper;
            this.projector = projector;
            this.screen = screen;
            this.lights = lights;
        }

        // Det er denne metode clienten kalder for at se en Film
        // Dette betyder at alt logik i metode udføres for Clienten,
        // uden client kender til implementationen 
        public void WatchMovie()
        {
            Console.WriteLine("Get ready to watch a movie...");
            popper.On();
            lights.Off();
            screen.Down();
            projector.TurnOn();
            amp.On();
            dvd.On();
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            popper.Off();
            lights.On();
            screen.Up();
            projector.TurnOff();
            amp.Off();
            dvd.Off();
        }

    }
}
