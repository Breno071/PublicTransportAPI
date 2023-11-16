using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PublicTransportAPI.Models.DTOS
{
    public class PosicaoVeiculoDTO
    {
        public double PoveLatitude { get; set; }
        public double PoveLongitude { get; set; }
        public long FkVeicId { get; set; }
    }
}
