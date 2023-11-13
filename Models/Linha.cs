namespace PublicTransportAPI.Models
{
    public class Linha
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Parada[] Paradas { get; set; }
    }
}
