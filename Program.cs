﻿using DesafioPOO.Models;
Console.WriteLine("Nokia");
Smartphone nokia = new Nokia("2122", "Nk32","111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Spotify");

Console.WriteLine();

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone("11111111", "Iphone Mil", "2222222", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Spotify");

/*
Apesar de não conseguirmos instanciar uma classe abstrata, ela pode ser passada como um tipo.
 Pois Nokia é um Smartphone, é uma relação de 'é um ', de ser um smartphone.
 O ideal é sempre que possível programar voltado à interface e não à implementação 
 */

 