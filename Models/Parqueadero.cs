namespace ParkYa.Models
{
    public class Parqueadero
    {
        public int id_Parqueadero { get; set; }

        public int cod_parqueadero { get; set; }

        public required string  direccion { get; set; }

        public required string nombre { get; set; }

        public int total_cupos { get; set; }

        public required string tipo_espacio { get; set; }
    }
}