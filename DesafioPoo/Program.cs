using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "4423-2112", modelo: "G52", imei: "6fguad63", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "2567-4382", modelo: "13 pro", imei: "7fj938", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");