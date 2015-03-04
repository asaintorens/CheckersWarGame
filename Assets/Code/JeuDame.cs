using Morpion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeuDames
{
   public class JeuDame
    {

        public Joueur joueur1;
        public Joueur joueur2;
        public Plateau plateauJeu;

        public bool AfficherInterfaceDebut;
        public bool AfficherInterfaceEnJeu;

        public bool animationEnCours;

        public JeuDame()
        {
            this.AfficherInterfaceDebut = true;
            this.AfficherInterfaceEnJeu = false;
            this.animationEnCours = false;
            this.plateauJeu = new Plateau(10, 10);

        }
        public void EtablirJoueur(string pseudoJ1,string pseudoJ2)
        {
            this.joueur1 = new Joueur();
            this.joueur2 = new Joueur();

            this.joueur1.Pseudo = pseudoJ1;
            this.joueur2.Pseudo = pseudoJ2;
        }

        public void LancerPartie()
        {
            this.AfficherInterfaceDebut = false;
            this.AfficherInterfaceEnJeu = true;
        }

        public void Update()
        {
            if(!this.animationEnCours)
            {
               

            }
        }

        

    }
}
