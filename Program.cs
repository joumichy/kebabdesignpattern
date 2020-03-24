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
            string[] kebabList ={"vegetarien", "pescetarien","normal"};

            Console.WriteLine("Bonjour, Voulez vous de la viande dans votre kebab ?");
            foreach(string elem in kebabList){
                 Console.WriteLine(elem);
            }
            choixKebab = Console.ReadLine().ToLower();
            string nomSauce = choixSauce();
            Kebab kebab;
            switch(choixKebab){
                kebabList[0]: kebab = new Kebab(true,true,true,false)
            }

            do{
                Console.WriteLine("Bonjour, Voulez vous de la viande dans votre kebab ? \n Oui/Non");
                reponse = Console.ReadLine();
                reponse.ToLower();
                Console.WriteLine(reponse);

            }while(reponse != "oui" && reponse != "non");
            
           
            
            bool value;
            if (reponse == "oui") value = true;
            else value = false;



        }
        static string choixSauce(){
            string reponse;
            Console.WriteLine("Quelle sauce voulez vous ?");
            reponse = Console.ReadLine().ToLower();
            Console.WriteLine(reponse);
            return reponse;
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
