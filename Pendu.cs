using System;

namespace JeuDuPendu
{
    public class Pendu
    {
        private List<string> mots = new List<string>
        {
            "souris",
            "maison",
            "ouragan",
            "vacances",
            "chameau",
            "chalumeau",
            "piano",
            "ordinateur"
        };
        private const int NbEssaiMax = 7;
        private int NbEssai;

        public List<char> LettresTestees { get; } = new List<char>();
        public string MotATrouver { get; private set; }
        public string MotCourant { get; private set; }

        public bool GagneOuPerdu()
        {
            return false;
        }

        public void TesterLettre(char c)
        {

        }

        public void AfficherPendu()
        {
            var template = "  --------------     " + Environment.NewLine +
                             "    |        1       " + Environment.NewLine +
                             "    |        1       " + Environment.NewLine +
                             "    |       2 2'      " + Environment.NewLine +
                             "    |       2'2¤2      " + Environment.NewLine +
                             "    |      44355     " + Environment.NewLine +
                             "    |        3       " + Environment.NewLine +
                             "    |        3       " + Environment.NewLine +
                             "    |       6 7      " + Environment.NewLine +
                            @"   /|\     6   7     " + Environment.NewLine +
                            @"  / | \              " + Environment.NewLine +
                            @" /  |  \             ";
            for (int i = 1; i <= NbEssaiMax; i++)
            {
                if (NbEssai >= i)
                {
                    if (i != 2)
                    {
                        template = template.Replace(i.ToString(), i switch
                        {
                            1 => "|",
                            3 => "|",
                            4 => "-",
                            5 => "-",
                            6 => "/",
                            7 => "\\",
                            _ => ""
                        });
                    }
                    else
                    {
                        template = template
                            .Replace("2'", "\\")
                            .Replace("2¤", "_")
                            .Replace("2", "/");
                    }
                }
                else
                {
                    template = template.Replace(i.ToString(), i switch
                    {
                        4 => " ",
                        _ => ""
                    })
                    .Replace("'", "").Replace("¤", "");
                }

            }
            Console.Write(template);
            Console.WriteLine();
        }
    }
}
