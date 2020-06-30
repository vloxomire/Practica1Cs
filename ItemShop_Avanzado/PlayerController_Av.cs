using System;
namespace ItemShop
{
    class PlayerController
    {
        Random random = new Random();
        Player player = new Player();
        int oroPlayerController;
        public PlayerController() 
        {
            this.oroPlayerController =0;
        }

        public int PlayerInicio()
        {
            Console.WriteLine(DateTime.Now);
            //NombrePlayer();
            OroInicial();
            oroPlayerController=player.GetOro();
            MostrarDatosPlayer();
            Console.ReadLine();
            return oroPlayerController;
        }
        public void NombrePlayer()
        {
            Console.WriteLine("Ingrese su nombre");
            player.SetNombre(Console.ReadLine());
        }

        public void OroInicial()
        {
            player.SetOro(random.Next(100, 500));
            Console.WriteLine("El player tiene {0} oro", player.GetOro());
        }

        public void MostrarDatosPlayer()
        {
            Console.WriteLine(("").PadRight(24, '-'));
            Console.WriteLine("{0}", player.GetNombre());
        }

        public void ComprarItem(int oro, bool disponible, int pos)
        {
            //paso posicion verifico q alla lugar en la mochila y oro


        }
    }
}
