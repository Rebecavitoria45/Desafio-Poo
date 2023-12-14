using DesafioPOO.Models;

Smartphone nokia1= new Nokia(numero:"345758494", modelo:"Modelo1", imei: "438393939", memoria: 64);
nokia1.Ligar();
nokia1.InstalarAplicativo("whatsApp");

Smartphone iphone1= new Iphone(numero:"987351560", modelo:"Modelo2", imei: "4938292949", memoria: 128);
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Instagram");