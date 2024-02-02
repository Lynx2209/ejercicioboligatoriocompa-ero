using ejercicioboligatoriocompañero.Servicios;
using ejercicioboligatoriocompañero.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioboligatoriocompañero.Servicios
{
    internal interface MenuInterfaz
    {
        public void Alumnocrear(List<dtosclase> alum);
        void alumnocrear(List<dtosclase> alumnos);
    }
}