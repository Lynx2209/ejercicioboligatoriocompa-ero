using ejercicioboligatoriocompañero;
using ejercicioboligatoriocompañero.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioboligatoriocompañero.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public void Alumnocrear(List<dtosclase> alum)
        {
            dtosclase alumnocrear = new dtosclase();
            Console.WriteLine("Escribe el nombre");
            alumnocrear.Nombre = Console.ReadLine();
            Console.WriteLine("Escribe el apellido");
            alumnocrear.Apellido = Console.ReadLine();
            Console.WriteLine("Escribe la clase");
            alumnocrear.Clase = Console.ReadLine();
            alum.Add(alumnocrear);
        }

        public void alumnocrear(List<dtosclase> alumnos)
        {
            throw new NotImplementedException();
        }

        
        
    }

}