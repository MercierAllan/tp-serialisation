using System;
using System.IO;
using System.Collections.Generic;
namespace Tp_serialisation;

class Program
{
    static void Main(string[] args)
{
    GestionJeux gestionJeux = new GestionJeux();

    gestionJeux.AjouterJeu(new JeuVideo("Minecraft", "Mojang", 29.99));
    gestionJeux.AjouterJeu(new JeuVideo("Mario Kart 8 Deluxe", "Nintendo", 59.99));
    gestionJeux.AjouterJeu(new JeuVideo("The Witcher 3", "CD Projekt", 39.99));

    // Sauvegarde
    gestionJeux.SauvegarderCSV("jeux.csv");
    gestionJeux.SauvegarderXML("jeux.xml");
    gestionJeux.SauvegarderJSON("jeux.json");

    Console.WriteLine("Lecture CSV");
    GestionJeux gestionCSV = new GestionJeux();
    gestionCSV.ChargerCSV("jeux.csv");
    gestionCSV.AfficherJeux();

    Console.WriteLine("Lecture XML");
    GestionJeux gestionXML = new GestionJeux();
    gestionXML.ChargerXML("jeux.xml");
    gestionXML.AfficherJeux();

    Console.WriteLine("Lecture JSON");
    GestionJeux gestionJSON = new GestionJeux();
    gestionJSON.ChargerJSON("jeux.json");
    gestionJSON.AfficherJeux();
}
}
