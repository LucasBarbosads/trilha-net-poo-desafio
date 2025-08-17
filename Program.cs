using DesafioPOO.Models;

Console.WriteLine("Usando o smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "2536486", modelo: "xr-90", imei: "2563486", memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("----------------------------------------");

Console.WriteLine("Usando o smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "9686413", modelo: "Iphone x", imei: "578864", memoria: 525);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");