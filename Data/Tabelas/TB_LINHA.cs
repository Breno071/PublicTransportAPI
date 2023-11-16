namespace PublicTransportAPI.Data.Tabelas
{
    public class TB_LINHA
    {
        public long LINHA_ID { get; set; }
        public string LINHA_NOME { get; set; }
        public long FkLinha { get; set; }
    }
}
