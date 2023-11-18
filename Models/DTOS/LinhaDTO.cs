using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PublicTransportAPI.Models.DTOS
{
    public class LinhaDTO
    {
        public string LinhaNome { get; set; } = string.Empty;
    }
}
