﻿using System;


namespace AchievementSystem
{
    class AchievementController
    {
        /*Para poder gestionar y testear los logros, crearemos una clase llamada
        AchievementController en el cual crearemos a mano algunos logros y los guardaremos
        en un arreglo.*/
        //Pq el enum afuera?
        enum LOGROS {EMPTY,KILL10,GOLD100,ESPADACHIN}
        LOGROS[] logrosArray;
        short indice=5;
        //Constructor
        public AchievementController() 
        {
            this.indice = indice;
            logrosArray=new LOGROS[indice];//Inicializo
            logrosArray[indice] = LOGROS.EMPTY;
            
        }
        public void Mostrar() 
        {
            Console.Write(logrosArray);
            Console.ReadLine();
        }

    }
}
