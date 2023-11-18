using Dapper.Contrib.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;

namespace PublicTransportAPI.Models
{
    [Table("TB_LINHA_PARADA")]
    public partial class LinhaParada
    {
        [Key]
        public long LinhaParadaId { get; set; }
        public long FkLinhaId { get; set; }
        public long FkParadaId { get; set; }

        public virtual Linha FkLinha { get; set; }
        public virtual Parada FkParada { get; set; }
    }
}