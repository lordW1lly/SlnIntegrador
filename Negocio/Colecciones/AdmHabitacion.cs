using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Models.Models.Base;
using Entidades.Models.Models.derivada;

namespace Negocio.Colecciones
{
    public static class AdmHabitacion
    {
        public static List<Habitacion> habitaciones; //aca estoy declarando la lista
        
        public static List <Habitacion> Listar()
        {
            habitaciones = new List<Habitacion>(); // aca estoy creando la lista
            habitaciones.Add(new Habitacion() { Id=123, Estado="ocupada", Numero=56});
            habitaciones.Add(new Habitacion() { Estado = "Libre", Numero = 36, Id = 890 });
            habitaciones.Add(new Habitacion() { Id = 874, Numero = 232, Estado = "Ocupada" });
            habitaciones.Add(new Habitacion() { Estado = "Fuera de Servicio", Numero = 123, Id = 43 });
            habitaciones.Add(new Habitacion() { Id = 234, Numero = 1234, Estado = "Libre" });
            return habitaciones;
        }
        public static List <Habitacion> Listar (string Estado)
        {
            return null;

        }
        public static int Insertar(Habitacion habitacion)
        {
            return 0;
        }

        public static int Eliminar(int Id)
        {
            return 0;
        }

        public static Habitacion TraerUno(int Numero)
        {
            return null;
        }
    }
}
