using System;

namespace ItemShop
{
    class ShopController
    {
        //Notemos como las clases tienen atributos (vars) sueltos por fuera de sus funciones. Esto nos permite trabajar con las variables de forma libre dentro
        //de la clase.
        static string[] weaponNames = { "ESPADA", "HACHA", "MARTILLO" };
        static string[] armorNames = { "ESCUDO", "CASCO", "HOMBRERAS" };
        static string[] potionNames = { "POCION SALUD", "POCION FUERZA", "POCION VELOCIDAD" };

        Item[] inventory;
        Random random;

        public void InitInventory(int size)
        {
            inventory = new Item[size];
            random = new Random();

            for (int i = 0; i < inventory.Length; i++)
            {
                inventory[i] = GenerateRandomItem();
            }
        }

        //Mostrar inventario
        public void ShowInventory()
        {
            //Nuestro CLS pasa a llamarse asi.
            Console.Clear();

            //Noten que usamos ahora .length para tomar el largo del inventario en lugar de un valor.
            //Esto nos permite adaptar nuestro codigo mediante parametros a cualquier tam.
            for (int i = 0; i < inventory.Length; i++)
            {
                inventory[i].SeeItem();
            }

            //Nuestro cin asi.
            Console.ReadLine();
        }

        //Se ocupa de generar un item random, creandolo localmente en el momento y devolviendolo.
        private Item GenerateRandomItem()
        {
            Item item = new Item();
            ITEM_TYPE type = (ITEM_TYPE)random.Next(0, 3);

            item.SetType(type);
            item.SetName(GetRandomName(type));
            item.SetCost(random.Next(0, 1000) + 1);

            return item;
        }

        //Recibe el ITEM_TYPE y segun cual sea lo convierte a texto.
        private string GetRandomName(ITEM_TYPE itemType)
        {
            string rName;

            switch (itemType)
            {
                case ITEM_TYPE.WEAPON:
                    rName = weaponNames[random.Next(0, weaponNames.Length)];
                    break;
                case ITEM_TYPE.ARMOR:
                    rName = armorNames[random.Next(0, armorNames.Length)];
                    break;
                case ITEM_TYPE.POTION:
                    rName = potionNames[random.Next(0, potionNames.Length)];
                    break;
                default:
                    rName = "ITEM";
                    break;
            }

            return rName;
        }
    }
}
