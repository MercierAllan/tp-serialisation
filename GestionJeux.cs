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
    public void RemoveJeu(JeuVideo jeu)
    {
        jeux.Remove(jeu);
    }
    public void AfficherJeux()
    {
        foreach (JeuVideo jeu in jeux)
        {
            Console.WriteLine($"Titre: {jeu.Titre}, Studio: {jeu.Studio}, Prix: {jeu.Prix}");
        }
    }


}