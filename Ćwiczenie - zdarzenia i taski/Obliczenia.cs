using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ćwiczenie___zdarzenia_i_taski
{
    public class Obliczenia
    {
        //TODO: klasa ma definiować zdarzenia "rozpoczecieObliczen", "progresObliczen", "zakonczenieObliczen"
        //TODO: zdarzenie "progresObliczen" ma mieć atrybut "progresObliczen_EventArgs" który przechowuje aktualną wartość zmiennej 'wynik'

        public int Obliczaj()
        {
            int wynik = -1;

            //TODO: wywołanie zdarzenia "rozpoczecieObliczen" bez atrybutów zdarzenia

            for (int i = 0; i <= 100; i++)
            {
                wynik++;
                Thread.Sleep(100);
                //TODO: wywołanie zdarzenia "progresObliczen" z atrybutem zdarzenia który zawierać ma aktualną wartość zmiennej 'wynik'
            }

            //TODO: wywołanie zdarzenia "zakonczenieObliczen" baz atrybutów zdarzenia

            return wynik;
        }
    }
}
