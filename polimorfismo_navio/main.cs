using System;

class MainClass {
  public static void Main (string[] args) {

    NavioMercante cargueiro = new NavioMercante("Noviozin", 50);
    NavioMercante cargueiru = new NavioMercante("Noviozão", 50, 1000);
    NavioMercante cargueiri = new NavioMercante("Noviozão", 50, 1000, 500);

    cargueiro.Carregamento();
    cargueiru.Carregamento();
    cargueiri.Carregamento();

    NavioDeGuerra ng1 = new NavioDeGuerra("Ng1", 100, 20);
    NavioDeGuerra ng2 = new NavioDeGuerra("Ng2", 100, 20);

    Console.WriteLine(ng2.EstadoDoNavio());
    Console.WriteLine(ng1 > ng2);
    Console.WriteLine(ng2.EstadoDoNavio());
    Console.WriteLine(ng1 > ng2);
    Console.WriteLine(ng2.EstadoDoNavio());
    Console.WriteLine(ng2 < ng1);
    Console.WriteLine(ng2.EstadoDoNavio());
    Console.WriteLine(ng1 < ng2);
    Console.WriteLine(ng2.EstadoDoNavio());
    Console.WriteLine(ng1 > ng2);
    Console.WriteLine(ng2.EstadoDoNavio());
    Console.WriteLine(ng1 > ng2);
    Console.WriteLine(ng2.EstadoDoNavio());
    Console.WriteLine(ng1 > ng2);
    Console.WriteLine(ng2.EstadoDoNavio());
    Console.WriteLine(ng1 > ng2);
    Console.WriteLine(ng2.EstadoDoNavio());

    ng2.Atacar(ng1);
    Console.WriteLine(ng1.EstadoDoNavio());
    ng2.Atacar(ng1);
    Console.WriteLine(ng1.EstadoDoNavio());

    NavioDeGuerra c1 = new Cruzador("c1", 200, 30, 4);
    NavioDeGuerra c2 = new Cruzador("c2", 150, 37, 2);

    Console.WriteLine(c1.EstadoDoNavio());
    Console.WriteLine(c2.EstadoDoNavio());

    NavioDeGuerra pa1 = new PortaAvioes("pa1", 200, 30, 2);
    NavioDeGuerra pa2 = new PortaAvioes("pa2", 150, 37, 1);

    Console.WriteLine(pa1.EstadoDoNavio());
    Console.WriteLine(pa2.EstadoDoNavio());

    c1.Atacar(pa1);
    Console.WriteLine(pa1.EstadoDoNavio());

    Console.WriteLine(pa1 > c2);
    Console.WriteLine(c2.EstadoDoNavio());

  }
}
