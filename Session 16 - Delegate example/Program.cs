


StringDelegate stringDelegate = ToUpperCase;
WriteOutput("this is a lowercase string", stringDelegate);



static void ToUpperCase(string text) => Console.WriteLine(text.ToUpper());

static void ToLowerCase(string text) => Console.WriteLine(text.ToLower());

void WriteOutput(string text, StringDelegate stringDelegate)
{
    Console.WriteLine($"Before {text}");
    stringDelegate.Invoke(text);
}

/*
stringDelegate("this is uppercase");
stringDelegate.Invoke("this is another uppercase string");


stringDelegate = ToLowerCase;
stringDelegate.Invoke("this is lowercase");*/


public delegate void StringDelegate(string text);
