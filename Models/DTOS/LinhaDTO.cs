namespace PublicTransportAPI.Models.DTOS
{
    public class LinhaDTO
    {
        public string Name { get; set; }
        public Parada[] Paradas { get; set; }
    }
}
