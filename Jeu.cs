using System;

namespace JeuDuPendu
{
    public class Jeu
    {
        private Pendu pendu = new Pendu();
        public void LancerJeu()
        {
            Console.Clear();

            while (pendu.GagneOuPerdu() == false)
            {
                Console.WriteLine($"Lettres testées : {string.Join(' ', pendu.LettresTestees)}");
                pendu.AfficherPendu();
                Console.WriteLine($"Mot actuel : {pendu.MotCourant}");
                Console.Write("Entrez une lettre : ");

                char saisie = RecupererSaisieUtilisateur();
                pendu.TesterLettre(saisie);
                Console.Clear();

            }

            GestionFinDeJeu();
        }



        private void GestionFinDeJeu()
        {
            Console.Clear();
            if (pendu.MotCourant == pendu.MotATrouver)
            {
                Console.WriteLine("Bravo vous avez gagné !");
            }
            else
            {
                Console.WriteLine("Dommage, vous avez perdu !");
            }
            pendu.AfficherPendu();
            Console.WriteLine($"Le mot à trouver était : {pendu.MotATrouver}");
        }

        private char RecupererSaisieUtilisateur()
        {
            char? saisie = null;
            while (saisie.HasValue == false)
            {
                try
                {
                    var consoleSaisie = Console.ReadLine();
                    if (string.IsNullOrEmpty(consoleSaisie) == false)
                    {
                        saisie = char.Parse(consoleSaisie);
                    }
                    else
                    {
                        saisie = null;
                    }
                }
                catch
                {
                    saisie = null;
                }
            }

            return saisie.Value;
        }
    }
}
