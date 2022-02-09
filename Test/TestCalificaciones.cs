using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using Modelo.Operaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Test
{
    public class TestCalificaciones
    {
            [Theory]
            [InlineData(1, 4.3f)]
            [InlineData(2, 4.6f)]
            [InlineData(3, 3.1f)]
            [InlineData(4, 2.3f)]
            [InlineData(5, 5.0f)]
            [InlineData(6, 1.4f)]
            [InlineData(7, 3.1f)]
            [InlineData(8, 1.4f)]
            [InlineData(9, 4.7f)]
            [InlineData(10, 3.5f)]
            [InlineData(11, 4.6f)]
            [InlineData(12, 3.1f)]
            [InlineData(13, 5.0f)]
            [InlineData(14, 1.9f)]
            [InlineData(15, 3.5f)]
            [InlineData(16, 4.2f)]
            [InlineData(17, 1.4f)]
            [InlineData(18, 2.4f)]
            [InlineData(19, 4.9f)]
            [InlineData(20, 4.8f)]
            [InlineData(21, 3.6f)]
            [InlineData(22, 1.7f)]
            [InlineData(23, 1.5f)]
        public void TestCalcCalificacion(int califId, float resEsperado)
            {
                var db = DBBuilder.GetDB();

                var calificacion = db.calificaciones
                   .Include(calif => calif.Postulacion_Det)
                       .ThenInclude(det => det.Postulacion)
                           .ThenInclude(post => post.Proveedor)
                   .Single(calif => calif.CalificacionId == califId);


                var config = new Configuracion()
                {
                    PesoNota1 = 0.5f,
                    PesoNota2 = 0.2f,
                    PesoNota3 = 0.15f,
                    PesoNota4 = 0.2f,
                    PesoNota5 = 0.15f,
                    PesoNota6 = 0.15f,
                    PesoNota7 = 0.10f,
                    NotaMinima = 4.1f
                };
                var calc = new CalculoCalificaciones(config);
                float resCalculado = calc.NotaFinal(calificacion);

                string mensaje = $"{resEsperado} distinto {resCalculado}: {calificacion.Postulacion_Det.Postulacion.Proveedor}";
                Assert.True(resEsperado == resCalculado, mensaje);

            }

            [Theory]
            [InlineData(1, true)]
            [InlineData(2, true)]
            [InlineData(3, false)]
            [InlineData(4, false)]
            [InlineData(5, true)]
            [InlineData(6, false)]
            [InlineData(7, false)]
            [InlineData(8, false)]
            [InlineData(9, true)]
            [InlineData(10, false)]
            [InlineData(11, true)]
            [InlineData(12, false)]
            [InlineData(13, true)]
            [InlineData(14, false)]
            [InlineData(15, false)]
            [InlineData(16, true)]
            [InlineData(17, false)]
            [InlineData(18, false)]
            [InlineData(19, true)]
            [InlineData(20, true)]
            [InlineData(21, false)]
            [InlineData(22, false)]
            [InlineData(23, false)]
        public void TestCalcCalificacionAprobado(int califId, bool resEsperado)
            {
                var db = DBBuilder.GetDB();

                var calificacion = db.calificaciones
                    .Include(calif => calif.Postulacion_Det)
                        .ThenInclude(det => det.Postulacion)
                            .ThenInclude(post => post.Proveedor)
                    .Single(calif => calif.CalificacionId == califId);


                var config = new Configuracion() { PesoNota1 = 0.5f, PesoNota2 = 0.2f, PesoNota3 = 0.15f,
                    PesoNota4 = 0.2f, PesoNota5 = 0.15f, PesoNota6 = 0.15f, PesoNota7 = 0.10f, NotaMinima = 4.1f };
                var calc = new CalculoCalificaciones(config);
                bool resCalculado = calc.Aprobado(calificacion);

                string mensaje = $"{resEsperado} distinto {resCalculado}: {calificacion.Postulacion_Det.Postulacion.Proveedor}";
                Assert.True(resEsperado == resCalculado, mensaje);

            }
        

        }
}
