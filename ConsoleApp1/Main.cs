using System;

namespace ItemShop 
{
    class Program
    {
        
        static void Main(string[] args)
        {
            const short TAM = 5;
            ShopController controller = new ShopController();
            PlayerController playerControl = new PlayerController();
            Mochila mochila = new Mochila();
            bool hayEspacioMain;
            char salir;
            short lugarDisponibleMain=0;
            Player player = new Player();
            Items[] mochil=new Items [TAM];

         
            int oroMain=playerControl.PlayerInicio();
            controller.InicializarInventario(TAM);
            
            //Ciclo Menu
            do
            {
                controller.MostrarInventario();
                //Hay espacio tiene que ser por referencia para poder mandar posicion
                hayEspacioMain = mochila.ComprobarEspacioMochila(mochil,ref lugarDisponibleMain);//resive el true del metodo
                /*Usar variable local para traer el get del oro al iniciar y usara esa pq cuando llama al metodo get no esta o setear por referencia*/
                oroMain=controller.ComprarItem(mochil, hayEspacioMain,oroMain,lugarDisponibleMain);
                Console.WriteLine(("").PadRight(24, '-'));
                mochila.VerMochila(mochil);
                Console.WriteLine("Desea salir del menu de compra?");
                Console.WriteLine("y/n");
                salir = Convert.ToChar(Console.ReadLine());
            } while (salir=='n');
            
            
        }
    }

}