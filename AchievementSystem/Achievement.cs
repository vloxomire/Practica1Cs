using System;
using System.Runtime.Remoting.Messaging;

namespace AchievementSystem
{
    class Achievement
    {
        private short id;
        private string titulo;
        private string descripcion;
        private short recompensa;
        private bool status;
        //Constructor
        public Achievement() 
        {
            this.id=0;
            this.titulo=" ";
            this.descripcion=" ";
            this.recompensa=0;
            this.status=false;
        }
        //Getter
        public  short GetId() 
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
        public short GetRecompensa() 
        {
            return recompensa;
        }
        public bool GetStatus() 
        {
            return status;
        }
        public void SetId(short id) 
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
        public void SetDescripcion(short id) 
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
        public void SetRecompensa(short id) 
        {
            short recompensa;
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
        public void SetStatus(short log) 
        {
            if (log >= 0) 
            {
                this.status = true;
            }
        }
        public void VerLogros()
        {
            //mostrando un listado, con la información de cada logro
            Console.WriteLine("Id:\t\t{0}\nTitulo:\t\t{1}\nDescripcion:\t{2}\nRecompensa:\t{3}\nStatus:\t\t{4}", id, titulo, descripcion, recompensa, status);
            Console.Write(("").PadRight(30,'*'));
            Console.ReadLine();
        }
        public void InicializarLogros(short id) 
        {
            SetId(id);
            SetTitulo((Logros)id);
            SetDescripcion(id);
            SetRecompensa(id);
            SetStatus(id);
        }
    }
}
