namespace WebApiFabian.Modelos
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public required string Matricula { get; set; }
        public required string Marca { get; set; }
        public required string Modelo { get; set; }
        public required string Color { get; set; }

    }
}
