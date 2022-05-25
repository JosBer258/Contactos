using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ApiSQL_Azure.Models;
using System.Linq;

namespace ApiSQL_Azure.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController: Controller
    {
        private ContactsContext  contactsContext;
        public ContactController(ContactsContext context){
                contactsContext = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Contacts>> Get(){
            return contactsContext.ContactSet.ToList();
            //Se hace uso del lenguaje LINQ para estructurar de mejor manera las operaciones de SQL, es un mini sub lenguaje
            //Siendo lenguaje de consultas.
        }

        //Si se crea un metodo constructor para establecer la comunicacion, es necesario un metodo destructor
        //Para hacer eso se usa el ALT + 126  ~
        ~ContactController(){
            contactsContext.Dispose();
            //Esto quiere decir que, cuando se salga del controlador, la memoria de la aplicacion se 
            //elimine para que no ocaciones un problema de hardware
        } 
    }
}