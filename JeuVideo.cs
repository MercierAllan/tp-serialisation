using System;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text.Json;
public class JeuVideo
{
    private string titre;
    private string studio;
    private double prix;

    public JeuVideo() { }

    public JeuVideo(string titre, string studio, double prix)
    {
        this.titre = titre;
        this.studio = studio;
        this.prix = prix;
    }

    public string Titre
    {
        get { return titre; }
        set { titre = value; }
    }

    public string Studio
    {
        get { return studio; }
        set { studio = value; }
    }

    public double Prix
    {
        get { return prix; }
        set { prix = value; }
    }
}