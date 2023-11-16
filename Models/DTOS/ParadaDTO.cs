using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PublicTransportAPI.Models.DTOS
{
    public class ParadaDTO
    {
        public string ParadaNome { get; set; }
        public double ParadaLatitude { get; set; }
        public double ParadaLongitude { get; set; }
    }
}
