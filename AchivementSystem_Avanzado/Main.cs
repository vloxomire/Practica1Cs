using System;
namespace AchievementSystem
{
    class ProgramMain
    {
        public static void Main()
        {
            AchievementController achCont = new AchievementController(); ;
            achCont.LLenarArray();
            achCont.MostrarArrayLogros();
            short pasos = 0;
            while (pasos<3) 
            {
                pasos++;
                achCont.AvanzarLogros(0);//ID
            }
            

        }
    }
}
