using System;
using System.Collections.Generic;

namespace Wymiary_Prostokąta.Services
{
    public class ProstokatService : IProstokatService
    {
        private List<Prostokat> _listaProstokatow = new List<Prostokat>();

        public double ObliczPole(int wysokosc, int szerokosc, string jednostka)
        {
            // Implementacja obliczania pola prostokąta
            // Możesz tutaj przekonwertować jednostki, jeśli są w różnych formatach
            return wysokosc * szerokosc;
        }

        public void DodajProstokat(int wysokosc, int szerokosc, string jednostka, DateTime data)
        {
            // Dodawanie prostokąta do listy
            _listaProstokatow.Add(new Prostokat { Wysokosc = wysokosc, Szerokosc = szerokosc, Jednostka = jednostka, DataDodania = data });
        }

        public List<Prostokat> GetProstokaty()
        {
            // Zwracanie listy prostokątów
            return _listaProstokatow;
        }
    }
}