using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PublicTransportAPI.Models.DTOS
{
    public class LinhaParadaDTO
    {
        public long FkLinhaId { get; set; }
        public long FkParadaId { get; set; }
        public TbLinha FkLinha { get; set; }
    }
}
