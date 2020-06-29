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
            /*maando un id recorro el aarray de obj, veo si coincide el ide entonces le paso true*/
            for (short i = 0; i < arrayLogros.Length; i++)
            {
                if (arrayLogros[i].GetId() == id)
                {
                    arrayLogros[i].SetStatus(true);
                    Console.WriteLine("Se a completado el siguente logro {0}", arrayLogros[i].GetTitulo());
                    arrayLogros[i].VerLogros();
                }
            }
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
