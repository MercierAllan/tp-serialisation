using System;
using System.IO;
using System.Collections.Generic;
namespace Tp_serialisation;

class Program
{
    static void Main(string[] args)
    {
        GestionJeux gestionJeux = new GestionJeux();

        JeuVideo jeu1 = new JeuVideo("Minecraft", "Mojang", 29.99);
        JeuVideo jeu2 = new JeuVideo("Mario Kart 8 Deluxe", "Nintendo", 59.99);
        JeuVideo jeu3 = new JeuVideo("The Wither 3", "CD Projekt", 39.99);

        gestionJeux.AjouterJeu(jeu1);
        gestionJeux.AjouterJeu(jeu2);
        gestionJeux.AjouterJeu(jeu3);

        Console.WriteLine("Liste des jeux vidéo:");
        gestionJeux.AfficherJeux();

        gestionJeux.SauvegarderCSV("jeux.csv");
    }
}
