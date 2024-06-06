using Session_19___Fasade_pattern;

Amplifier amp = new Amplifier();
CdPlayer cd = new CdPlayer();
DvdPlayer dvd = new DvdPlayer();
PopcornPopper popper = new PopcornPopper();
Projector projector = new Projector();
Screen screen = new Screen();
TheaterLights lights = new TheaterLights();

HomeTheaterFacade homeTheater = 
    new HomeTheaterFacade(amp, cd, dvd, popper, projector, screen, lights);

homeTheater.WatchMovie(); 
homeTheater.EndMovie(); 
