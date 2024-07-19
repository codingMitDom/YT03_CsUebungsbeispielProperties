using CsTutorial;

// Deklaration und Initialisierung
Hund bello = new Hund();
//bello.Name = "";    // Test Name Leerstring
//bello.Name = null;  // Test Name null (keine Referenz)
bello.Name = "Bello";
//bello.Alter = 51; // Test zu großer Wert
//bello.Alter = -1; // Test zu kleiner Wert
bello.Alter = 3;


// Ausgabe
bello.Bellen();
Console.WriteLine($"Das Alter von {bello.Name} ist {bello.Alter}.");