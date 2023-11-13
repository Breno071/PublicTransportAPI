namespace PublicTransportAPI.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Modelo { get; set; }
        public long LinhaId { get; set; }
    }
}
