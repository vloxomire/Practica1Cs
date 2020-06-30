using System;
using System.Runtime.Remoting.Messaging;

namespace AchievementSystem
{
    class Achievement
    {
        private int id;
        private string titulo;
        private string descripcion;
        private int recompensa;
        private bool status;
        private int contador;
        private int total;
        //Constructor
        public Achievement() 
        {
            this.id=0;
            this.titulo=" ";
            this.descripcion=" ";
            this.recompensa=0;
            this.status=false;
            this.contador=0;
            this.total=0;
    }
        //Getter
        public  int GetId() 
        {
            return id;
        }
        public string GetTitulo() 
        {
            return titulo;
        }
        public string GetDescripcion() 
        {
            return descripcion;
        }
        public int GetRecompensa() 
        {
            return recompensa;
        }
        public bool GetStatus() 
        {
            return status;
        }
        public int GetContador()
        {
            return contador;
        }
        public int GetTotal()
        {
            return total;
        }
        public void SetId(int id) 
        {
            this.id=id;
        }
        public void SetTitulo(Logros titulo) 
        {
            string titu;
            switch (titulo)
            {
                case Logros.KILL10:
                    titu = "Killer";
                    break;
                case Logros.GOLD100:
                    titu = "Empresario";
                    break;
                case Logros.ESPADACHIN:
                    titu = "Espadachin";
                    break;
                default:
                    titu = " ";
                    break;
            }
            this.titulo = titu;
        }
        public void SetDescripcion(int id) 
        {
            string descripcion;
            switch (id)
            {
                case 0:
                    descripcion = "Matar 10 enemigos";
                    break;
                case 1:
                    descripcion = "Juntar 10 de oro";
                    break;
                case 2:
                    descripcion = "Combatir 10 peleas con espada";
                    break;
                default:
                    descripcion = " ";
                    break;
            }
            this.descripcion = descripcion;
        }
        public void SetRecompensa(int id) 
        {
            int recompensa;
             switch (id)
            {
                case 0:
                    recompensa = 10;
                    break;
                case 1:
                    recompensa = 100;
                    break;
                case 2:
                    recompensa = 200;
                    break;
                default:
                    recompensa = 0;
                    break;
            }
            this.recompensa = recompensa;
        }
        public void SetStatus(bool status) 
        {
            this.status = status;
        }
        public void SetContador(int contador)
        {
            this.contador = contador;
        }
        public void SetTotal(int id)
        {
            short total = 0;
            switch (id)
            {
                case 0:
                    total = 5;
                    break;
                case 1:
                    total = 10;
                    break;
                case 2:
                    total = 15;
                    break;
                default:
                    break;
            }
            this.total = total;
        }
        public void VerLogros()
        {
            //A partir de ahora al mostrar los logros tenemos que mostrar sus pasos actuales y totales.
            //EJ: Asesino - Matar 10 enemigos - 5 / 10 - G300//contador??
            Console.WriteLine("Id:\t\t{0}\nTitulo:\t\t{1}\nDescripcion:\t{2}\nRecompensa:\t{3}\nStatus:\t\t{4}\n\t\t{5}/{6}", id, titulo, descripcion, recompensa, status,contador,total);
            Console.Write(("").PadRight(30,'*'));
            Console.ReadLine();
        }
        public void InicializarLogros(int id) 
        {
            SetId(id);
            SetTitulo((Logros)id);
            SetDescripcion(id);
            SetRecompensa(id);
            SetStatus(false);
            SetContador(0);
            SetTotal(id);
        }
    }
}
