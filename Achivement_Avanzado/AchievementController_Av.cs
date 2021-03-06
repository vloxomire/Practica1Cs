﻿using System;
namespace AchievementSystem
{
    public enum Logros { KILL10, GOLD100, ESPADACHIN }
    class AchievementController
    {
        const short indice=3;
        Achievement[] arrayLogros;
        private int botin;
        //Constructor
        public AchievementController() 
        {
            arrayLogros = new Achievement[indice];
            this.botin = 0;
        }
       
        public void CompletarLogro(int id) 
        {
            /*maando un id recorro el aarray de obj, veo si coincide el ide entonces le paso true*/
            for (short i = 0; i < arrayLogros.Length; i++)
            {
                if (arrayLogros[i].GetId() == id && arrayLogros[i].GetContador() == arrayLogros[i].GetTotal() && arrayLogros[i].GetStatus() == false)
                {
                    arrayLogros[i].SetStatus(true);
                    Console.WriteLine("Se a completado el siguente logro {0}", arrayLogros[i].GetTitulo());
                    arrayLogros[i].VerLogros();
                    this.botin=botin+arrayLogros[i].GetRecompensa();
                }
                else
                {
                    Console.WriteLine("{0}\t{1}/{2}",arrayLogros[i].GetTitulo(), arrayLogros[i].GetContador(), arrayLogros[i].GetTotal());
                    Console.ReadLine();
                }
            }
        }
        public Achievement GeneradorLogros() 
        {
            //metodo del tipo clase Achievement(por ende retorna un objeto de esa clase)
            Achievement ach = new Achievement();//Creo una instancia y  la inicializo
            Logros log = Logros.ESPADACHIN;//Lugar de memoria del tipo enum Logros, guarda un tipo de enum
            short logNum = (short)log;
            ach.SetTitulo(log);
            ach.SetId(logNum);
            ach.SetDescripcion(logNum);
            ach.SetRecompensa(logNum);
            return ach;
        }
        public void MostrarArrayLogros() 
        {
            for (short i = 0; i < arrayLogros.Length; i++)
            {
                arrayLogros[i].VerLogros();
            }
        }
        public void LLenarArray() 
        {
            
            for (short i = 0; i < arrayLogros.Length; i++)
            {
                arrayLogros[i]=new Achievement();
            }
            for (short i = 0; i < arrayLogros.Length; i++)
            {
                arrayLogros[i].InicializarLogros(i);
            }
        }
        public void AvanzarLogros(int id,int pasos)
        {
            /*enviando una ID, tendremos que ir
            avanzando los pasos y preguntar de forma interna en la clase Achievement si está
            completo y preguntar si me pase de los pasos
            Aumenta en 1*/
            for (short i = 0; i < arrayLogros.Length; i++)
            {
                if (arrayLogros[i].GetId() == id)
                {
                    //Pregunto si ya esta completo o me paso de los pasos
                    if (arrayLogros[i].GetTotal() == arrayLogros[i].GetContador())
                    {
                        Console.WriteLine("El logro ya esta completo");
                        break;
                    }
                    else 
                    {
                        if (pasos>arrayLogros[i].GetTotal())
                        {
                            pasos = arrayLogros[i].GetTotal();
                        }
                        arrayLogros[i].SetContador(pasos);
                        CompletarLogro(id);
                    }
                }
            }
        }
        public int GetBotin() 
        {
            return botin;
        }
    }
}
