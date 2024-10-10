using DesafioPOO.Models;

Smartphone nokia = new Nokia("(24) 999999999","NoGy","464646465465465", 128);
nokia.InstalarAplicativo("Tinder");
nokia.Ligar();
nokia.ReceberLigacao();

Console.WriteLine("\n");

Smartphone iphone = new Nokia("(24) 988888888", "Pro Max" , "46464464987979", 256);
iphone.InstalarAplicativo("Twitter");
iphone.Ligar();
iphone.ReceberLigacao();
// TODO: Realizar os testes com as classes Nokia e Iphone