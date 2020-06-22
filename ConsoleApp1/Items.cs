using System;
namespace ItemShop
{
    //Al declarar el enum fuera de la clase item, pero dentro del namespace ItemShop estamos diciendo que es parte de este namespace y no de la clase.
    //Similar al concepto de global que manejabamos antes, solo que esta contenido dentro ItemShop.
    enum ITEM_TYPE { WEAPON, ARMOR, POTION,EMPTY }

    class Item
    {
        //Atributos de item.
        //La pregunta que hay que hacer es:
        //Que cosas tiene un item?
        private string name;  //un nombre
        private ITEM_TYPE type; //un tipo de item
        private int cost; //un costo

        //Funciones SETTERS para configurar una variable sin acceder directamente a esta.
        //Esto es parte de las reglas de OOP, encapsulacion. Vamos a verlo la prox clase.
        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetType(ITEM_TYPE type)
        {
            this.type = type;
        }

        public void SetCost(int cost)
        {
            this.cost = cost;
        }

        public void SeeItem()
        {
            Console.WriteLine("El item {0} de tipo {1} tiene un costo de {2}", name, GetTypeName(type), cost);
        }

        private static string GetTypeName(ITEM_TYPE type)
        {
            string name;

            switch (type)
            {
                case ITEM_TYPE.WEAPON:
                    name = "ARMA";
                    break;
                case ITEM_TYPE.ARMOR:
                    name = "ARMADURA";
                    break;
                case ITEM_TYPE.POTION:
                    name = "POCION";
                    break;
                default:
                    name = "ITEM";
                    break;
            }

            return name;
        }
    }
}

