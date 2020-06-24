using System;
namespace ItemShop
{
    class PlayerController
    {
        Random random = new Random();
        Player player = new Player();

        public void PlayerInicio()
        {
            Console.WriteLine(DateTime.Now);
            //NombrePlayer();
            OroInicial();
            MostrarDatosPlayer();
            Console.ReadLine();

        }
        public void NombrePlayer()
        {
            Console.WriteLine("Ingrese su nombre");
            player.SetNombre(Console.ReadLine());
        }

        public void OroInicial()
        {
                player.SetOro(random.Next(1, 250));
        }

        public void MostrarDatosPlayer()
        {
            Console.WriteLine(("").PadRight(24, '-'));
            Console.WriteLine("{0} tiene {1} oro", player.GetNombre(), player.GetOro());
        }

        public void ComprarItem(int oro, bool disponible, int pos)
        {
            //paso posicion verifico q alla lugar en la mochila y oro


        }
    }
}
