﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace PublicTransportAPI.Models
{
    public partial class TbPosicaoVeiculo
    {
        public long PoveId { get; set; }
        public double PoveLatitude { get; set; }
        public double PoveLongitude { get; set; }
        public long FkVeicId { get; set; }

        public virtual TbVeiculo FkVeic { get; set; }
    }
}