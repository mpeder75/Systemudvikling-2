using Session_13___Interfaces;

Database db = new Database();

db.WriteToTextFile("Homer");
db.WriteToTextFile("Marge");
db.WriteToTextFile("Bart");
db.WriteToTextFile("Lisa");
db.WriteToTextFile("Maggie");
db.ReadFromTextFile();


/*
db.EmptyFile();
db.ReadFromTextFile();*/