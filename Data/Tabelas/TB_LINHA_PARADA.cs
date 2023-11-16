namespace PublicTransportAPI.Data.Tabelas
{
    public class TB_LINHA_PARADA
    {
        public long LINHA_PARADA_ID { get; set; }
        public long FK_LINHA_ID { get; set; }
        public long FK_PARADA_ID { get; set; }
        public long FkLinhaId { get; set; }
        public long FkParadaId { get; set; }
    }
}
