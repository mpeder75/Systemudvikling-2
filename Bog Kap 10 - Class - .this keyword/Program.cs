
SimpleTime myTime = new SimpleTime(15,30,19);

Console.WriteLine(myTime.BuildString());



class SimpleTime
{
    public int Hour { get; set; }
    public int Minute { get; set; }
    public int Second { get; set; }

    public SimpleTime(int hour, int minute, int second)
    {
        this.Hour = hour;       // set "this" object's Hour instance variabel
        this.Minute = minute;
        this.Second = second;
    }

    public string BuildString() => $"{"this.ToUniversalString()",24}: {this.ToUniversalString()}" + $"\n{"ToUniversalString()",24} : {ToUniversalString()}";

    public string ToUniversalString() => $"{this.Hour:D2}:{this.Minute:D2}:{this.Second:D2}";
}


