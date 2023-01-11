using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.Models;
using WebApplication1.Response;
using WebApplication1.Request;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class clienteController : ControllerBase
    {

        VentaRealContext db = new VentaRealContext();
        Respuesta re = new Respuesta();
        Cliente cliente = new Cliente();

        [HttpGet]
        public IActionResult Get()
        {
            try
            {

                var lst = db.Clientes.ToList();

                re.Mensaje = "Ha sido exitoso";
                re.Datos = lst;
                re.Exito = 1 ;

               

            }
            catch(Exception ex) 
            {
                re.Mensaje = ($"Ha ocurrido un error y es {ex} ");

            }

            return Ok(re);
        }

        [HttpPost]
        public IActionResult add(clientRequest omodel) 
        {
            try
            {
                cliente.Nombre = omodel.name.ToString();

                re.Exito = 1;
                re.Mensaje = "Funciono correcatente";

              

                db.Clientes.Add(cliente);
                db.SaveChanges();

                re.Datos = cliente;
               


            } catch(Exception ex) 
            {

                re.Mensaje = $"Ha ocurrido un error {ex}" ;
            
            }

            return Ok(re);
        
        }


        [HttpPut]

        public IActionResult edit (clientRequest omodel) 
        {
            try
            {

                cliente = db.Clientes.Find(omodel.id);

                cliente.Nombre = omodel.name.ToString();

                re.Exito = 1;
                re.Mensaje = "Funciono correcatente";



                db.Entry(cliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

                db.SaveChanges();

                re.Datos = cliente;

            }
            catch (Exception ex) 
            {
                re.Mensaje = $"Ha ocurrido un error {ex}";

            }
            return Ok(re);


        }


        [HttpDelete("{id}")]
        public IActionResult delete(int id) 
        {
            try
            {
                cliente = db.Clientes.Find(id);

                db.Remove(cliente);
                db.SaveChanges();


                re.Exito = 1;
                re.Mensaje = "Se ha borrado con exito";

            }catch (Exception ex) 
            {

                re.Mensaje = $"Ha fallado algo y es {ex}";
                re.Exito = 2;
            }
            return Ok(re);
        }

    }
}
