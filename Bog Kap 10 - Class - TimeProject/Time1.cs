namespace Bog_Kap_10___Class___TimeProject
{
    public class Time1
    {
        public int Hour { get; set; }  
        public int Minute { get; set; }
        public int Second { get; set; }


        public void SetTime(int hour, int minute, int second) 
        {
            // Der valideres i constructor, at når properties skal sættes, skal de overholde UT timeformat
            if (hour < 0 || hour > 23 || minute < 0 || minute > 59 || second < 0 || second > 59 ) 
            {
                throw new ArgumentOutOfRangeException();
            }

            Hour = hour;
            Minute = minute;
            Second = second;
        }

      
        // konvertere string til UT time format (HH:MM:SS)
        public string ToUniversalString() => $"{Hour:D2}:{Minute:D2}:{Second:D2}";

        // konvertere string til standard time format (H:MM:SS AM or Pm)
        public override string ToString() => $"{((Hour == 0 || Hour == 12) ? 12 : Hour % 12)}" + $"{Minute:D2}:{Second:D2} {(Hour < 12 ? "Am" : "Pm")}";
    }
}
