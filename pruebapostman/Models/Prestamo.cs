namespace pruebapostman.Models
{
    public class Prestamo
    {
        public int IDPrestamo { get; set; }
        public int IDLibro { get; set; }
        public int IDCliente { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
    }

}
