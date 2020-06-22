using System;

namespace ItemShop
{

    //Clase principal, una clase es una serie de atributos y metodos.
    class Program
    {

        //En este caso, nuestra clase solo tiene un metodo main. Noten que es estatico.
        //Esto tiene un motivo, el cual explicaremos mas adelante.
        static void Main()
        {
            const int shopSize = 10;

            //Creamos una instancia de shopcontroller y la guardamos en controller
            ShopController controller = new ShopController();

            //llamamos funciones publicas
            controller.InitInventory(shopSize);
            controller.ShowInventory();
        }
    }
}
