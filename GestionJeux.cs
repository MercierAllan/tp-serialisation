using System;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text.Json;
class GestionJeux
{
    private List<JeuVideo> jeux;

    public GestionJeux()
    {
        jeux = new List<JeuVideo>();
    }

    public void AjouterJeu(JeuVideo jeu)
    {
        jeux.Add(jeu);
    }

    public void AfficherJeux()
    {
        foreach (JeuVideo jeu in jeux)
        {
            Console.WriteLine($"Titre : {jeu.Titre} | Studio : {jeu.Studio} | Prix : {jeu.Prix} euros");
        }
    }

    // CSV 

    public void SauvegarderCSV(string nomFichier)
    {
        StreamWriter writer = new StreamWriter(nomFichier);
        foreach (JeuVideo jeu in jeux)
        {
            writer.WriteLine($"{jeu.Titre};{jeu.Studio};{jeu.Prix}");
        }
        writer.Close();
        Console.WriteLine("Sauvegarde CSV effectuée.");
    }

    public void ChargerCSV(string nomFichier)
    {
        if (File.Exists(nomFichier))
        {
            jeux.Clear();
            StreamReader reader = new StreamReader(nomFichier);

            while (!reader.EndOfStream)
            {
                string ligne = reader.ReadLine();
                string[] morceaux = ligne.Split(';');
                string titre = morceaux[0];
                string studio = morceaux[1];
                double prix = Convert.ToDouble(morceaux[2]);
                JeuVideo jeu = new JeuVideo(titre, studio, prix);
                jeux.Add(jeu);
            }
            reader.Close();
            Console.WriteLine("Chargement CSV effectué.");
        }
        else
        {
            Console.WriteLine("Le fichier CSV n'existe pas.");
        }
    }

    // XML 

    public void SauvegarderXML(string nomFichier)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<JeuVideo>));
        StreamWriter writer = new StreamWriter(nomFichier);
        serializer.Serialize(writer, jeux);
        writer.Close();
        Console.WriteLine("Sauvegarde XML effectuée.");
    }

    public void ChargerXML(string nomFichier)
    {
        if (File.Exists(nomFichier))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<JeuVideo>));
            StreamReader reader = new StreamReader(nomFichier);
            jeux = (List<JeuVideo>)serializer.Deserialize(reader);
            reader.Close();
            Console.WriteLine("Chargement XML effectué.");
        }
        else
        {
            Console.WriteLine("Le fichier XML n'existe pas.");
        }
    }
    //JSON 
    public void SauvegarderJSON(string nomFichier)
    {
        string json = JsonSerializer.Serialize(jeux);
        File.WriteAllText(nomFichier, json);
        Console.WriteLine("Sauvegarde JSON effectuée.");
    }

    public void ChargerJSON(string nomFichier)
    {
        if (File.Exists(nomFichier))
        {
            string json = File.ReadAllText(nomFichier);
            jeux = JsonSerializer.Deserialize<List<JeuVideo>>(json);
            Console.WriteLine("Chargement JSON effectué.");
        }
        else
        {
            Console.WriteLine("Le fichier JSON n'existe pas.");
        }
    }
}