﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WilmerRentCar.BOL
{
    public class RentaDevolucion : BaseEntity
    {
        public int Renta { get; set; }
        public int VehiculoId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaRenta { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public int Dias { get; set; }
        public bool ServicioDomicilio { get; set; }
        public Vehículo Vehiculo { get; set; }
        public Usuario Usuario { get; set; }
    }
}
