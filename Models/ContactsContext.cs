using Microsoft.EntityFrameworkCore;
//Esta es para optener una clase llamada DB CONTEXT, el namespace es

namespace ApiSQL_Azure.Models
{
    public class ContactsContext: DbContext
    {
        //Es hora de vincularlas
        //Esta clase establecera o sabra que recibir de azure
        //Ahora podra heredar de BCONTEXT, permitiendo optener una clase constructora, el nombre del metodo 
        //consrtructor debe
        //coencidiir cpon el nombre de la clase.

        public ContactsContext (DbContextOptions options): base (options){
            //se crea el constructor, se manda el parametro de context opcion y su nombre, estas opciones se
            // obtendran de la clase base poniendo BASE (options)
        }

        //Es una coleccion que vienen de la base de datos, ña propiedad DBSERT va agarrar lo que se optiene
        // de SQL y lov va a recibir, es donde todo va a llegar
        public DbSet<Contacts> ContactSet {get; set;} 

        //Ahora se va a APPSETTINGS pars que reciba la cadena de conexion
        //DbSet es una colección de los datos que vienen de la Base de Datos(en este caso SQL Azure).public DbSet<contacts> Contacts { get; set; }
    }
}