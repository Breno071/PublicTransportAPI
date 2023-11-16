using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PublicTransportAPI.Models.DTOS
{
    public class VeiculoDTO
    {
        public string VeicNome { get; set; }
        public string VeicModelo { get; set; }
        public long FkLinhaId { get; set; }
        public TbLinha FkLinha { get; set; }
    }
}
