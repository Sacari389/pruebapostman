namespace pruebapostman.Models
{
    public class Libro
    {
        public int IDLibro { get; set; }
        public string Titulo { get; set; }
        public int AutorID { get; set; }
        public int GeneroID { get; set; }
        public string ISBN { get; set; }
        public int Stock { get; set; }
    }

}
