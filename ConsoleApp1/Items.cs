using System;
namespace ItemShop 
{
    enum ITEMS { pocion, arma, armadura };
    class Items
    {
        private ITEMS tipoItems;
        private string nombre;
        private int costo;

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;

        }

        public void SetCosto(int costo)
        {
            this.costo = costo;
        }
        public int GetCosto() 
        {
            return costo;
        }

        public void SetItems(ITEMS item)
        {
            this.tipoItems = item;
        }
        public ITEMS GetItems() 
        {
            return tipoItems;
        }
        public void VerItem()
        {
            Console.WriteLine("El item {0} de tipo {1} con coste {2}$", DameTipoNombre(tipoItems), nombre   , costo);
        }

        private static string DameTipoNombre(ITEMS it)
        {
            string nombre;

            switch (it)
            {
                case ITEMS.pocion:
                    nombre = "POCIONES";
                    break;
                case ITEMS.arma:
                    nombre = "ARMAS";
                    break;
                case ITEMS.armadura:
                    nombre = "ARMADURA";
                    break;
                default:
                    nombre = "ITEM";
                    break;
            }
            return nombre;
        }
    }
}
