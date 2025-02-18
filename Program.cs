using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero:"12345",modelo:"3320",imei:"4444",memoria:32);
nokia.Ligar();
nokia.InstalarAplicativo("Snake");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero:"7890",modelo:"Iphone 16",imei:"777",memoria:512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");