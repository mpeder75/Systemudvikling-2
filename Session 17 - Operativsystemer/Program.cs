namespace Session_17___Operativsystemer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            System.Diagnostics.Process.Start("xcopy", "\"c:\\test1\\*.*\" c:\\"+"\"\\test2\\*.*\""+" /S/Y");
        }
    }
}
