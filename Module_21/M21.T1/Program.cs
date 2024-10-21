// See https://aka.ms/new-console-template for more information

using M21.T1;

Console.WriteLine("Hello, World!");

GardenService gardenService = new GardenService(5, 5);
gardenService.StartWork();