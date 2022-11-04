using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Models.Models.derivada;

namespace Negocio.Colecciones
{
    public static class AdmPaciente
    {
         static List<Paciente> pacientes;

        public static  List<Paciente> Listar()
        {
            pacientes = new List<Paciente>();
            pacientes.Add(new Paciente() {  Apellido="Jofre", Id=234, Telefono=456, Domicilio ="Alvare 456", Email="Godoy 23", Nombre="Esteban", NroHistoriaClinica="D2345" });
            pacientes.Add(new Paciente() { NroHistoriaClinica = "D234", Nombre = "Manuela", Email = "Didsd@dsd", Domicilio = "Batalla 234", Telefono = 234, Id = 234, Apellido = "Seppia" });
            pacientes.Add(new Paciente() { Apellido = "Dominguez", Id = 234, Telefono = 454, Domicilio = "Joko 123", Email = "elmail", Nombre = "Flavia", NroHistoriaClinica = "D234" });
            pacientes.Add(new Paciente() { NroHistoriaClinica = "D323", Nombre = "Juana", Email = "dsd", Domicilio = "Las Heras 67", Telefono = 34556, Id = 234, Apellido = "Estevez" });
            pacientes.Add(new Paciente() { Apellido = "Castro", Id = 2345, Telefono = 234, Domicilio = "Italia 345", Email = "DSdsd", Nombre = "Flavia", NroHistoriaClinica = "Dfdfd" });
            return pacientes;
        }
        public static int Insertar(Paciente paciente)
        {
            return 0;
        }
        public static int Eliminar(int Id)
        {
            return 0;
        }
        public static Paciente TraerUno(string NroHistoriaClinica)
        {
            return null;
        }
    }
}
