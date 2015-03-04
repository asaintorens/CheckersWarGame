using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Morpion
{
    public class Plateau
    {
        private int NombreCaseX;
        private int NombreCaseY;
        private Case caseSelectionne; 
        public List<Case> ListeCase { get; set; }

        public Plateau(int nombreCaseX, int nombreCaseY)
        {
            this.NombreCaseX = nombreCaseX;
            this.NombreCaseY = nombreCaseY;
            this.ListeCase = new List<Case>();
            bool couleurCase = true;
            for (int compteurX = 0; compteurX < nombreCaseX; compteurX++)
            {
                for (int compteurY = 0; compteurY < nombreCaseY; compteurY++)
                {
                    string resources = "";
                    if(couleurCase)
                    {
                        resources = "CaseBlanche";
                        couleurCase = false;
                    }else
                    {
                        resources = "CaseMarron";
                        couleurCase = true;
                    }
                    Case uneCase = new Case(compteurX, compteurY);
                    uneCase.Resources = resources;
                    ListeCase.Add(uneCase);
                    if(compteurY+1==nombreCaseY)
                    {
                        if (couleurCase)
                            couleurCase = false;
                        else
                            couleurCase = true;
                    }
                }
            }
        }

        public void placerPion(Position position, Pion pion)
        {
            Case uneCase = this.GetCase(position);
            if (uneCase != null)
            {
                if (uneCase.Pion == null)
                {
                    uneCase.Pion = pion;
                    this.caseSelectionne = uneCase;
                }
                else
                    throw new Exception("Cette case est déjà utilisé.");
            }
            else
                throw new Exception("Cette case n'existe pas.");
        }

        public Case GetCase(Position position)
        {
            Case caseRes = null;
            foreach (Case uneCase in this.ListeCase)
            {
                if (uneCase.Position.Compare(position))
                {
                    caseRes = uneCase;
                }

            }
            return caseRes;
        }

        public bool EstPlein()
        {
            int nombreCaseRemplies = 0;
            foreach (Case uneCase in this.ListeCase)
            {
                if (uneCase.Pion != null)
                {
                    nombreCaseRemplies++;
                }
            }
            return nombreCaseRemplies == this.NombreCaseX * this.NombreCaseY;
        }

        internal Case DerniereCase()
        {
            throw new NotImplementedException();
        }



     

  

        public Case DerniereCasePose()
        {
            return this.caseSelectionne;
        }

        internal void EtablirCaseSelectionne(int x, int y,Pion pion)
        {
          Case uneCase =   GetCase(x, y);
          if (uneCase.Pion == null)
              throw new Exception("Pas de pion a cet endroit");
          else
              if(uneCase.Pion.TypePion.ToString() != pion.TypePion.ToString())
              {
                  throw new Exception("Ce pion n'est pas le votre");
              }

          this.caseSelectionne = uneCase;
        }

        private Case GetCase(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
