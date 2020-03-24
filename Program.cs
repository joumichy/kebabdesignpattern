using System;

namespace designpattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string reponse;
            string choixKebab;
            string genreKebab;
             string choixsauce;
            string[] kebabList ={"vegetarien", "pescetarien","normal"};

            /////////////////////////////////

            Console.WriteLine("Bonjour Quel genre de Kebab voulez vous ? \n :");
            foreach(string elem in kebabList){
                 Console.WriteLine(elem);
            }
            choixKebab = Console.ReadLine().ToLower();
            //////////////////////////////
           
            Console.WriteLine("Quelle sauce voulez vous ?");
            choixsauce = Console.ReadLine().ToLower();
            ////////////////////////
            Kebab kebab;
            switch(choixKebab){

                case "vegetarien" : 
                 kebab = new Kebab(true,true,true,false,choixsauce);break;

                case "pescetarien" : 
                kebab = new Kebab(true,true,true,false,choixsauce);break;

                case "normal" : 
                kebab = new Kebab(true,true,true,true,choixsauce);break;
            }

            Console.WriteLine("Vous avez choisis un Kebab :"+choixKebab + "avec la sauce :" +choixsauce);


        }



    }

    public class Kebab
    {
        bool salade,tomate,oignon,viande;
        string nomSauce;
        public Kebab(bool salade, bool tomate, bool oignon,bool viande, string nomSauce ){
            this.salade = salade;
            this.tomate = tomate;
            this.oignon = oignon;
            this.viande = viande;
            this.nomSauce = nomSauce;

        }

        public bool getSalade(){
            return this.salade;
        }
        public bool getTomate(){
            return this.tomate;
        }
        bool getOignon(){
            return this.oignon;
        }
        public bool getViande(){
            return this.viande;
        }
        public string getnomSauce(){
            return this.nomSauce;
        }

       public void setSalade(bool salade){
            this.salade = salade;

        }
        public void setTomate(bool tomate){
             this.tomate = tomate;
        }
         public void setOignon(bool oignon){
             this.oignon = oignon;
        }

         public void setViande(bool viande){
             this.viande = viande;
        }

       public void setNomSauce(string nomSauce){
             this.nomSauce = nomSauce;
        }
    }
}
