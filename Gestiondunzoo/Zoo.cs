using System;
using System.Collections.Generic;
using System.Text;

namespace Gestiondunzoo
{
    class Zoo
    {
        // private string Nom;
        //private int nbcage;
       // private  List<string> listeanimaux = new List<string>();
        

        public string Nom { get; set; }
        public int nbcage  { get; set; }
        public List<Animal> listeanimaux { get; set; } = new List<Animal>();


        ///////////////////////Constructeur/////////////////////////////////////////////////////////////

        public Zoo ( string Nom, int nbcage )
        {
            this.Nom = Nom;
            this.nbcage = nbcage;

        }
        
        public void  ajouter ( Animal A)
           
        {
            listeanimaux.Add(A);


        }

        public void Afficher ( )
        {
            
            foreach (Animal A in listeanimaux )
            {

               Console.WriteLine( A.Nom);
            }
         
             
            
        }


        public override string ToString()
        {
           
            string monzoo = "  " ;


            foreach (Animal A in listeanimaux)
            {

                monzoo = monzoo + " " +A.Nom;

               
            }

            return "Le nom du zoo est " + Nom + " il y ' a dans ce zoo " + monzoo;

        }



    }
}
