using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia tests");
Nokia n1 = new Nokia("9898-4545-3", "Primal", "012345678901234", 32);
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nIphone tests");
Iphone a1 = new Iphone("555-3435-101", "Iphone 16", "123456789012345", 128);
a1.Ligar();
a1.ReceberLigacao();
a1.InstalarAplicativo("Genshin Impact");
