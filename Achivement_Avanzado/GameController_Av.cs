using System;
namespace AchievementSystem
{
    class GameController
    {
        /*GameController el cual
        permitirá mostrar los logros, ingresar un input numérico e ir viendo como se van
        desbloqueando.
        Debemos ver en pantalla la cantidad de logros desbloqueados y el oro ganado*/
        AchievementController controller;
        int id;
        int pasos;
        public GameController() 
        {
            controller = new AchievementController();
            this.id = 0;
            this.pasos = 0;
        }
        public void Inicializar()
        {
            int salir=1;
            controller.LLenarArray();
            do
            {
                controller.MostrarArrayLogros();
                Console.WriteLine("Elija el id para el logro");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Elija la cantidad de \"pasos\" para el logro");
                pasos = Convert.ToInt32(Console.ReadLine());
                controller.AvanzarLogros(id, pasos);//recibe un id
                Console.WriteLine("Dinero actual {0}$",controller.GetBotin());
                Console.WriteLine("Desea salir marque 0 sino marque cualquier otro numero");
                salir = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
            } while (salir!=0);
            
        }
        

    }
}
