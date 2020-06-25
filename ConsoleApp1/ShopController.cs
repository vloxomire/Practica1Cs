using System;
using System.IO;

namespace ItemShop
{
    class ShopController
    {

        static string[] armasNombres = { "espada", "hacha", "martillo" };
        static string[] armadurasNombres = { "cuero", "malla", "placas" };
        static string[] pocionesNombres = { "vida", "defensa", "ataque" };
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
                this.inventario[i] = GeneradorItems();
            }
        }

        public void MostrarInventario()
        {
            short contador = 0;
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
        public void FiltroShop() 
        {
            int aux = 0;
            /*tenemos una nueva funciòn en el ShopController que nos permite indicarle un
            tipo de Item y mostrar la lista filtrada.*/
            //Tomar y Convertir
            Console.Write("Que tipo de item desea filtar:");
            Console.WriteLine("(0)pocion, (1)arma, (2)armadura");
            aux=Convert.ToInt32(Console.ReadLine());
            ITEMS it=(ITEMS)aux;
            //filtrar
            for (int i = 0; i < inventario.Length; i++)
            {
                /*ERROR:NO puedo llamar a la funcion gettype,no se si
                tomar valores de los indices o mostrar los indices*/
                if (it == inventario[i].GetItems()) 
                {
                    Console.Write("{0})",i);
                    switch (it)
                    {
                        case ITEMS.pocion:
                            inventario[i].VerItem();
                            break;
                        case ITEMS.arma:
                            inventario[i].VerItem();
                            break;
                        case ITEMS.armadura:
                            inventario[i].VerItem();
                            break;
                        default:
                            break;
                    }
                }   
            }
        }
        public int ComprarItem(Items[] mochi,bool hayEspacioCI,int oroSC,short lugarDisponibleCI)
        {
            /*Comprar ahora items depende del oro de nuestro jugador y de los espacios de la
            mochila.Debemos actualizar sus valores correctamente luego de hacer los chequeos necesarios.*/
            bool pobre = false;
            int indiceCompra;
            do 
            {
                Console.WriteLine("Que objeto desea comprar escriba su indice");
                indiceCompra = Convert.ToInt32(Console.ReadLine());
            } while(indiceCompra >mochi.Length && indiceCompra <0);
            //ERROR ,cuando quiero evitar q se le mande un enter,igual explota.
            Console.WriteLine("El indice elegido es {0}", indiceCompra);

            //Factura tipo A
            Console.WriteLine(("").PadRight(24, '*'));
            Console.WriteLine($"Coste:\t{inventario[indiceCompra].GetCosto(),8:c}");
            Console.WriteLine($"Oro:\t{oroSC,8:c}");
            Console.WriteLine(("").PadRight(24, '-'));
            Console.WriteLine($"Oro Restante:\t{oroSC-inventario[indiceCompra].GetCosto(),8:c}");
            //si costo supera el valor del oro no se puede hacer la transaccio y un mensaje
            if (inventario[indiceCompra].GetCosto() > oroSC)
            {
                Console.WriteLine("NO TIENE SUFICIENTE ORO, le falta {0}$"
                    , inventario[indiceCompra].GetCosto() - oroSC);
                pobre = true;
            }
            else 
            {
                oroSC = oroSC - inventario[indiceCompra].GetCosto();
                Console.WriteLine("FELICITACIONES POR LA COMPRA");
                Console.WriteLine("el remito se le enviara a su mail");
                pobre = false;
            }
            Console.WriteLine(("").PadRight(24, '*'));

            //Si el oro da negativo dice no lo puede comprar, si da saldo positivo o 0 lo comprar
            if (hayEspacioCI==true && !pobre) //Pregunta por oro y espacio
            {
                mochi[lugarDisponibleCI] = inventario[indiceCompra];
                inventario[indiceCompra] = GeneradorItems();
            }
            return oroSC;
        }
    }
}


