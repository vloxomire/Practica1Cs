using System;
namespace ItemShop 
{
    class ShopController
    {

        static string[] armasNombres = { "espada","hacha","martillo"};
        static string[] armadurasNombres = {"cuero","malla","placas"};
        static string[] pocionesNombres = { "vida","defensa","ataque"};
        Items[] objetos;

        Random random;

        public void InicializarInventario(short t)
        {

            objetos = new Items[t];
            random = new Random();

            for (int i = 0; i < objetos.Length; i++)
            {
                objetos[i] =GeneradorItems();
            }
        }

        public void MostrarInventario()
        {
            Console.Clear();
            for (int i = 0; i < objetos.Length; i++)
            {
                objetos[i].VerItem();
            }
            Console.ReadLine();
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

    }
}


