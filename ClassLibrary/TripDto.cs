using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    //DTO = data transfer object
    public class TripDto
    {
        //Properties
        public decimal TurStartPris { get; set; } = 27m;
        public decimal Køretid { get; set; }
        public decimal ForventetKørtKm { get; set; }
        public List<Tillæg> ValgteTillæg { get; set; }

        public Boolean Storvogn { get; set; }
        public bool Nattakst { get; set; } //nattask vs dagtaks
        public bool BestiltTur { get; set; } //Gadetur vs BestiltTur

        //Constructor, som i dette tilfælde sætter vores properties ved oprettelse af et objetk
        public TripDto(decimal forventetKørtKm, decimal køretid)
        {
            ForventetKørtKm = forventetKørtKm;
            Køretid = køretid;
        }

        public TripDto()
        {

        }
    }

    public enum Tillæg
    {
        CykelOpbæringOgHjælp,
        Lufthavn,
        Storebælt,
        Øresund,
        MeetGreet
    }
}
