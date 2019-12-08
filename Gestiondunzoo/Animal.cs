
using System;

namespace Gestiondunzoo
{
    class Animal
    ///////////////////////////////////////////////////////////////////attribut////////////////////////////////////////////////////////////
    {
        // private string race;
        //private string Nom;
        // private int poids;

        /// <summary>
        /// /////////////////   Constructeur/////////////////////////////////////////////////////////////////////////////////////////////

        public Animal(string Nom, string race, int poids)
        {
            this.Nom = Nom;
            this.race = race;
            this.poids = poids;

            // Console.WriteLine("Le nom de l'animal est " + Nom + " c' est un " + race + "et il pése" + poids + "Kg");
        }
        /////////////////////////////////// Getter Setter///////////////////////////////////////////////////////////////////
        public string Nom { get; set;}
        public string race { get; set; }
        public int poids { get; set; }
      
        public override string ToString()
        {
            return "Le nom de l'animal est " + Nom + " c' est un  " + race + " et il pése" + poids + "Kg";

        }

         public void Afficher ()
        {
           Console.WriteLine( "Le nom de l'animal est " + Nom + " c' est un " + race  +"et il pése" + poids + "Kg" );

        }
          
           
      

         
    }

}
