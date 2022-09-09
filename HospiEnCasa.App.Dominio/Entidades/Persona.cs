using System;
namespace HospiEnCasa.App.Dominio
{
    public class Persona
    {
        public int Id {get;set;}
      /// Cada uno de los atributos de la clase persona
        public string Nombre{get;set;}
        
        public string Apellidos{get;set;}
        
        public string NumeroTelefono{get;set;}
        
        public Genero Genero{get;set;}
    }
}