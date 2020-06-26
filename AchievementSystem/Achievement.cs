using System;


namespace AchievementSystem
{
    class Achievement
    {
        /*Nuestro programa tendrá una clase Achievement el cual tendrá:
        ● ID
        ● titulo
        ● descripción
        ● recompensa
        ● status*/
        short ID;
        string titulo;
        string descripcion;
        string recompensa;
        string status;
        //Constructor
        public Achievement() 
        {
            this.ID=0;
            this.titulo="";
            this.descripcion="";
            this.recompensa="";
            this.status="";
        }
    
        public void VerLogros() 
        {
            /*● Ver logros (mostrando un listado, con la información de cada logro)*/
        }
        public void CompletarLogro() 
        {
            /*● Completar logro, enviando un ID y viendo si coincide.*/
    }
}
}
