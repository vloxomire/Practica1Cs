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
            achCont.CompletarLogro(2);

        }
    }
}
