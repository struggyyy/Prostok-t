using System;
using System.Collections.Generic;

namespace Wymiary_Prostokąta.Services
{
    public interface IProstokatService
    {
        // Metoda do obliczania pola prostokąta
        double ObliczPole(int wysokosc, int szerokosc, string jednostka);

        // Metoda do dodawania prostokąta do listy
        void DodajProstokat(int wysokosc, int szerokosc, string jednostka, DateTime data);

        // Metoda do pobierania listy prostokątów
        List<Prostokat> GetProstokaty();
    }

    // Klasa reprezentująca prostokąt
    public class Prostokat
    {
        public int Wysokosc { get; set; }
        public int Szerokosc { get; set; }
        public string Jednostka { get; set; }
        public DateTime DataDodania { get; set; }
    }
}
