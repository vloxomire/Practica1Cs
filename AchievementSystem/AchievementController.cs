using System;
namespace AchievementSystem
{
    public enum Logros { KILL10, GOLD100, ESPADACHIN }
    class AchievementController
    {
        /*Para poder gestionar y testear los logros
         * crearemos a mano algunos logros y los guardaremos
        en un arreglo.*/
        //Pq el enum afuera?
        const short indice=3;
        Achievement[] arrayLogros;
        
        //Constructor
        public AchievementController() 
        {
            arrayLogros = new Achievement[indice];
        }
       
        public void CompletarLogro(short id) 
        {
           /* for (int i = 0; i < logrosArray.Length; i++)
            {
                //el Array tendria q ser de objetos asi podria comprarr el id
                //if (id == logrosArray[i].)
                {

                }
            }*/
        }
        public Achievement GeneradorLogros() 
        {
            //metodo del tipo clase Achievement(por ende retorna un objeto de esa clase)
            Achievement ach = new Achievement();//Creo una instancia y  la inicializo
            Logros log = Logros.ESPADACHIN;//Lugar de memoria del tipo enum Logros, guarda un tipo de enum
            short logNum = (short)log;
            ach.SetTitulo(log);
            ach.SetId(logNum);
            ach.SetDescripcion(logNum);
            ach.SetRecompensa(logNum);
            ach.SetStatus(logNum);
            return ach;
        }
        public void MostrarArrayLogros() 
        {
            for (short i = 0; i < arrayLogros.Length; i++)
            {
                arrayLogros[i].VerLogros();
            }
        }
        public void LLenarArray() 
        {
            
            for (short i = 0; i < arrayLogros.Length; i++)
            {
                arrayLogros[i]=new Achievement();
            }
            
            for (short i = 0; i < arrayLogros.Length; i++)
            {
                
                arrayLogros[i].InicializarLogros(i);
                
            }
        }
    }
}
