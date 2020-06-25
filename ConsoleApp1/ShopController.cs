using System;
namespace ItemShop 
{
    class ShopController
    {

        static string[] armasNombres = { "espada","hacha","martillo"};
        static string[] armadurasNombres = {"cuero","malla","placas"};
        static string[] pocionesNombres = { "vida","defensa","ataque"};
        Items[] inventario;
        Mochila mochila;

        Random random;

        public void InicializarInventario(short t)
        {

            inventario = new Items[t];
            random = new Random();
            mochila = new Mochila();

            for (int i = 0; i < inventario.Length; i++)
            {
                inventario[i] =GeneradorItems();
            }
        }

        public void MostrarInventario()
        {
            short contador=0;
            Console.Clear();
            for (int i = 0; i < inventario.Length; i++)
            {
                if (inventario[i] == null)
                {
                    Console.WriteLine("Null");
                    contador++;
                }
                else
                {
                    Console.Write(contador + ") ");
                    inventario[i].VerItem();
                    contador++;
                }
            }
            //Console.ReadLine();
        }

        private Items GeneradorItems()
        {
            Items items = new Items();
            ITEMS tipo = (ITEMS)random.Next(0, 3);

            items.SetItems(tipo);
            items.SetNombre(GetTipoNombres(tipo));
            items.SetCosto(random.Next(0, 500) + 1);
            return items;
        }

        private string GetTipoNombres(ITEMS i) 
        {

            string tipoObj;
            switch (i)
            {
                case ITEMS.pocion:
                    tipoObj = pocionesNombres[random.Next(0, pocionesNombres.Length)];
                    break;
                case ITEMS.arma:
                    tipoObj = armasNombres[random.Next(0, armasNombres.Length)];
                    break;
                case ITEMS.armadura:
                    tipoObj = armadurasNombres[random.Next(0, armadurasNombres.Length)];
                    break;
                default:
                    tipoObj = "Items";
                    break;
            }
            return tipoObj;
        }

        public void ComprarItem(Items[] mochi,int pos) 
        {
            //Comprar item (al comprarse se borra del arreglo y se genera uno nuevo en su posiciòn)

            int indiceCompra;
            Console.WriteLine("Que objeto desea comprar escriba su indice");
            indiceCompra = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El indice elegido es {0}", indiceCompra);

            mochi[pos]=inventario[indiceCompra];
            inventario[indiceCompra] = GeneradorItems();
        }
    }
}


