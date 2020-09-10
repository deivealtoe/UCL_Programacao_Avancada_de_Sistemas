using System;

class MainClass {
    static void Main(string[] args) {
        
        Mamifero m1 = new Cachorro("Jubileia", new DateTime(2020, 5, 3), "Labrador");
        Mamifero m2 = new Gato("Clementina", new DateTime(2020, 4, 15), "Persa");

        Console.WriteLine(m1.Parir());
        Console.WriteLine(m2.Parir());

    }
}