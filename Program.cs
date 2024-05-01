using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Iniciando seu Nokia");
Smartphone nokia = new Nokia(numero: "12345", modelo: "Nokia G11 Plus", imei: "233444", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");
nokia.ExibirInformacoes();

Console.WriteLine("\n");

Console.WriteLine("Iniciando seu Iphone");
Smartphone iphone = new Iphone(numero: "67890", modelo: "Iphone 13", imei: "566777", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
iphone.ExibirInformacoes();

Console.WriteLine("\n");