using System.ComponentModel.DataAnnotations;

namespace Wymiary_Prostokąta.Models
{
    public class ProstokatViewModel
    {
        [Required(ErrorMessage = "Wysokość jest wymagana")]
        [Range(0, 1000000, ErrorMessage = "Wysokość musi być liczbą dodatnią mniejszą niż 1 000 000")]
        public int Wysokosc { get; set; }

        [Required(ErrorMessage = "Szerokość jest wymagana")]
        [Range(0, 1000000, ErrorMessage = "Szerokość musi być liczbą dodatnią mniejszą niż 1 000 000")]
        public int Szerokosc { get; set; }

        [Required(ErrorMessage = "Wybierz jednostkę")]
        public string Jednostka { get; set; }

        // Dodatkowe pole do przechowywania wyniku
        public double Wynik { get; set; }

        // Flaga określająca, czy wynik został obliczony
        public bool CzyObliczono { get; set; }
    }
}
