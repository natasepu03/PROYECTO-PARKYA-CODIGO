namespace ParkYa.Models
{
    public class Reserva
    {
        public int id_reserva { get; set; }

        public int cod_reserva { get; set; }

        public DateTime fecha { get; set; }

        public TimeSpan hora_entrada { get; set; }

        public TimeSpan hora_salida { get; set; }

        public required string estado { get; set; }

        public int Usuario_id_usuario { get; set; }

        public int Tarifas_id_tarifas { get; set; }

        public int Vehiculo_id_vehiculo { get; set; }
    }
}