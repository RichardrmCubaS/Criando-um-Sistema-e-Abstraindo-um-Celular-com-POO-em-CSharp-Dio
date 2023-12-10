using DesafioPOO.Models;

Console.WriteLine("Teste do Iphone");
Smartphone iphone = new Iphone(numero: "99111-1111", modelo: "14", imei: "111111111", memoria: 128);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
   

Console.WriteLine("---------------------------------");


Console.WriteLine("Teste do nokia");
Smartphone nokia = new Nokia(numero: "98222-2222", modelo: "N95", imei: "000000000", memoria: 64);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("TikTok");
    