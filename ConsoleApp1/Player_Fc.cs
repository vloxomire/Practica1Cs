﻿using System;

namespace ItemShop
{
    class Player
    {
        private string nombre;
        private int oro;

        public Player()
        {
            nombre = "Jugador";
            oro = 0;
        }
        public void SetNombre(string nom) 
        {
            this.nombre = nom;
        }
        public void SetOro(int oro) 
        {
            this.oro = oro;
        }
        public string GetNombre() 
        {
            return nombre;
        }
        public int GetOro() 
        {
            return oro; 
        }
    }
}
