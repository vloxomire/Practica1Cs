using System;
enum ITEMS { pocion, arma, armadura };
class Items
    {
    ITEMS items;
    string nombre;
    int costo;

    public void GenerarItem()
    {
        nombre = " ";
        var rand = new Random();

        costo = rand.Next(100);
        items = (ITEMS)rand.Next(2);

        switch (items)
        {
            case ITEMS.pocion:
                nombre = "vida";
                break;
            case ITEMS.arma:
                nombre = "espada";
                break;
            case ITEMS.armadura:
                nombre = "escudo";
                break;
            default:
                break;
        }
        Console.Write(items + nombre + costo);
    }
}

