using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Models.Models.derivada;

namespace Negocio.Colecciones
{
    public static class AdmMedico
    {
        
        static List <Medico> medicos; // Aca declaro la lista medicos
        public static List <Medico> Listar() 
        {
            medicos = new List<Medico>(); //Aca la estoy creando e instanciando
            // se instan
            //TODO... 
            medicos.Add(new Medico() { Especialidad = "Pediatra", Nombre = "Jorge", Apellido = "Suarez", Domicilio = "LAS Tipas 123", Email = "bla@bla", Id = 1234, Matricula = "546", Telefono = 4587 });
            medicos.Add(new Medico() { Especialidad = "Traumatologo", Telefono = 4512, Matricula = "265", Id = 125, Email = "dsds", Domicilio = "Lujan 123", Apellido = "Salut", Nombre = "Gustavo" });
            medicos.Add(new Medico() { Especialidad = "Clinico", Nombre = "Damian", Apellido = "Jofre", Domicilio = "San Martin 456", Email = "elmail@mail", Id = 535, Matricula = "584D", Telefono = 45832 });
            medicos.Add(new Medico() { Especialidad = "Cirujano", Telefono = 35541, Matricula = "T542", Id = 365, Email = "ñdsds@fmsd", Domicilio = "Sauce 456", Apellido = "Dominguez", Nombre = "Josefa" });
            medicos.Add(new Medico() { Especialidad = "Clinico", Nombre = "Josue", Apellido = "Tope", Domicilio = "El lugar457", Email = "googl@mail", Id = 214, Matricula = "fdfd4", Telefono = 4512 });
            return medicos;
           
        }
        public static List <Medico> Listar(string especialidad)
        {
            List<Medico> medicosConEspecialidad = new List<Medico> { }; // pq con {}? y no con ()?
            foreach(Medico medico in medicos)
            {
                if(medico.Especialidad == especialidad)
                {
                    medicosConEspecialidad.Add(medico);
                }
            }
            return medicosConEspecialidad;
        }

        public static int Insertar (Medico medico)
        {
            //TODO..

            return 0;
        }

        public static int Eliminar (int Id)
        {
            return 0;
        }
        public static Medico TraerUno (int Id)
        {
            return null ;
        }
    }
}
