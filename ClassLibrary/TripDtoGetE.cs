using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    //DTO = data transfer object
    public class TripDtoGetE
    {
        //Properties
        public decimal ForventetKørtKm { get; set; }

        public decimal EkstraDistance { get; set; }
        public List<TillægGetE> ValgteTillæg { get; set; }

        public bool Storvogn { get; set; }
        //Constructor, som i dette tilfælde sætter vores properties ved oprettelse af et objetk

        public TripDtoGetE(decimal forventetKørtKm)
        {
            ForventetKørtKm = forventetKørtKm;
        }

        public TripDtoGetE()
        {
        }
    }

    public enum TillægGetE
    {
        Storebælt,
        Øresund,
        MeetGreet
    }
}
