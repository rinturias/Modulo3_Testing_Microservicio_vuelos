﻿using Aerolinea.Vuelos.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Aerolinea.Vuelos.Test.Application.Dto
{
    public class RequestVueloDto_Test
    {
        [Fact]
        public void RequestVueloDto_CheckPropertiesValid()
        {
            DateTime horaSalidaTest = new DateTime();
            DateTime horaLLegadaTest = new DateTime();
            var estadoTest = "A";
            decimal precioTest = new(40.0);
            var StockAsientosTest = 50;
            DateTime fechaTest = new DateTime();

            var codDestinoTest = Guid.NewGuid(); 
            var codOrigenTest = Guid.NewGuid(); 
            var codAeronaveTest = Guid.NewGuid(); ;
            var activoTest = 0;

            var detalletripulacionesTest = getDetalleTripulacion();

            var objRequestVuelo = new RequestVueloDto();

            Assert.Equal(new DateTime(), objRequestVuelo.horaSalida);
            Assert.Equal(new DateTime(), objRequestVuelo.horaLLegada);
            Assert.Null(objRequestVuelo.estado);
            Assert.Equal(new decimal(0.0), objRequestVuelo.precio);
            Assert.Equal(0, objRequestVuelo.StockAsientos);
            Assert.Equal(new DateTime(), objRequestVuelo.fecha);

            Assert.Equal(Guid.Empty, objRequestVuelo.codDestino);
            Assert.Equal(Guid.Empty, objRequestVuelo.codOrigen);
            Assert.Equal(Guid.Empty, objRequestVuelo.codAeronave);
            Assert.Empty(objRequestVuelo.tripulaciones);



            objRequestVuelo.horaSalida = horaSalidaTest;
            objRequestVuelo.horaLLegada = horaLLegadaTest;
            objRequestVuelo.estado = estadoTest;
            objRequestVuelo.precio = precioTest;
            objRequestVuelo.StockAsientos = StockAsientosTest;
            objRequestVuelo.fecha = fechaTest;

            objRequestVuelo.codDestino = codDestinoTest;
            objRequestVuelo.codAeronave = codAeronaveTest;
            objRequestVuelo.activo = activoTest;
            objRequestVuelo.tripulaciones = detalletripulacionesTest;



            Assert.Equal(horaSalidaTest, objRequestVuelo.horaSalida);
            Assert.Equal(horaLLegadaTest, objRequestVuelo.horaLLegada);
            Assert.Equal(estadoTest, objRequestVuelo.estado);
            Assert.Equal(precioTest, objRequestVuelo.precio);
            Assert.Equal(StockAsientosTest, objRequestVuelo.StockAsientos);
            Assert.Equal(fechaTest, objRequestVuelo.fecha);
            Assert.Equal(codDestinoTest, objRequestVuelo.codDestino);
            Assert.Equal(codOrigenTest, objRequestVuelo.codAeronave);
            Assert.Equal(activoTest, objRequestVuelo.activo);
            Assert.Equal(detalletripulacionesTest.Count, objRequestVuelo.tripulaciones.Count);
         

        }

        private List<TripulacionDto> getDetalleTripulacion()
        {
            return new List<TripulacionDto>()
            {
                new()
                {
                    codVuelo = Guid.NewGuid(),
                    codTripulacion = Guid.NewGuid(),
                    codEmpleado = Guid.NewGuid(),
                    estado = "A",
                    activo = 0,
                  
                },
                new()
                {
                    codVuelo = Guid.NewGuid(),
                    codTripulacion = Guid.NewGuid(),
                    codEmpleado = Guid.NewGuid(),
                    estado = "A",
                    activo = 0,
                },
                new()
                {
                    codVuelo = Guid.NewGuid(),
                    codTripulacion = Guid.NewGuid(),
                    codEmpleado = Guid.NewGuid(),
                    estado = "A",
                    activo = 0,
                }
            };
        }
    }
}

