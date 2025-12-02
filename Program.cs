using DesafioPOO.Models;

Iphone iphone_10 = new Iphone("1111-1111", "Pro Max 10", "2451354", 8);
Iphone iphone_11 = new Iphone("2222-2222", "Pro Max 11", "7456844", 12);
Nokia nokia_1 = new Nokia("3333-3333", "Nokia 11", "56456456", 12);
Nokia nokia_2 = new Nokia("4444-4444", "Nokia 10", "456456", 12);


iphone_10.Ligar();
iphone_10.ReceberLigacao();
iphone_10.InstalarAplicativo("GOOGLE MAPS");

iphone_11.Ligar();
iphone_11.ReceberLigacao();
iphone_11.InstalarAplicativo("GOOGLE MAPS");

nokia_1.Ligar();
nokia_1.ReceberLigacao();
nokia_1.InstalarAplicativo("GOOGLE MAPS");


nokia_1.Ligar();
nokia_1.ReceberLigacao();
nokia_1.InstalarAplicativo("GOOGLE MAPS");


nokia_2.Ligar();
nokia_2.ReceberLigacao();
nokia_2.InstalarAplicativo("GOOGLE MAPS");