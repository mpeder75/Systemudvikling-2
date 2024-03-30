/*
 
Singleton gør at man kun kan have en instans af sin singleton class

SKAL indeholde:
 • variabel af datatypen Singleton, der opbevare Singleton instans
 • private Constructor, så man ikke kan new udefra
 • private static metode, der tjekker om variabel indeholder en instans af Singleton,
   ellers vil den instanciere en ny instans i variablen  
  
*/



class Singleton
{
    private static Singleton instance;

    private Singleton()
    {
    }

    public static Singleton getInstance()
    {
        if (instance == null)  
        {
            instance = new Singleton();  
        }
        return instance;        
    }
}

//! Hvordan får man Singleton fra program.cs?
//  Singleton.getInstance();


