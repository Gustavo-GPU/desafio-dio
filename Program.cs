using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smarthphone Nokia:");
Smartphone nokia = new Nokia (numero: "1234-5678", modelo: "Modelo X", imei: "123456", memoria: 64 );
nokia.Ligar();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone (numero: "5678-1234", modelo: "Modelo Y", imei: "123123", memoria: 128 );
iphone.Ligar();
iphone.InstalarAplicativo("Canva");
