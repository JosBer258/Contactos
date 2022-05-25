using System.ComponentModel.DataAnnotations;
//Permite establecer el primery Kwy con la anotacion especifica de anotacion de datos

namespace ApiSQL_Azure.Models{
    public class Contacts{
        //Modelo Vista y Controlador . El modelo contiene el esqueleto de la estructura con la que se va a comunicar
        //Lo que hara es permitir saber como se va a optnener la informacion de SQL y se le dara forma, es el molde
        //que permitira que esa ifnromacion sea reconocible o estructurada dentro del API


        //todas las bases de datos de SQL podrian tener una llave principal, es necesario saber indexalra con todos los demas
        [Key]
        public string Identificador { get; set; }

        public string Nombre { get; set; }

        public string Email { get; set; }

        public string  Telefono { get; set; }
        //el siguiente paso es crear la configuracion necearia para que la clase sea reconocida al momento de ejecutar.
        //ahora se usa la herramienta ENTITY FRAMEWORK CORE que es el puente entre la base de datos y el API
        //traduce la informacion de un lado a otro.


    }
}