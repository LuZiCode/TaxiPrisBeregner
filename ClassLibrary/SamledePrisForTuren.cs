using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SamledePrisForTuren
    {
        private readonly TripDto _tripDto;
        private decimal prisprKM = 0;
        private decimal priceØresund = 390;
        private decimal priceStorebælt = 490;
        private decimal priceCykel = 30;
        private decimal priceLufhavn = 15;


        public SamledePrisForTuren(TripDto tripDto)
        {
            _tripDto = tripDto;
            BestiltEllerGadeTur();
            TillægBeregner();
        }

        public decimal TillægBeregner()
        {
            decimal result = 0;
            if (_tripDto.ValgteTillæg.Contains(Tillæg.Øresund))
            {
                result += priceØresund;
            }
            if (_tripDto.ValgteTillæg.Contains(Tillæg.Storebælt))
            {
                result += priceStorebælt;
            }
            if (_tripDto.ValgteTillæg.Contains(Tillæg.CykelOpbæringOgHjælp))
            {
                result += priceCykel;
            }
            if (_tripDto.ValgteTillæg.Contains(Tillæg.Lufthavn))
            {
                result += priceLufhavn;
            }
            
            return result;
        }

        public decimal BestiltEllerGadeTur()
        {
            //Hvis det er en bestilt tur
            if (_tripDto.BestiltTur == true)
            {
                return BestiltTur();
            }
            //hvis det er en gade tur
            if (_tripDto.BestiltTur == false)
            {
                return GadeTur();
            }
            else
            {
                return 0;
            }
        }

        private decimal BestiltTur()
        {
            //Hvis det er en storvogn
            if (_tripDto.Storvogn == true)
            {
                //hvis det er nat takst
                if (_tripDto.Nattakst == true)
                {
                    prisprKM = 17m; //kr
                    _tripDto.TurStartPris = 77; //kr
                    var prisForKM = _tripDto.ForventetKørtKm * prisprKM;
                    var prisForKørerTiden = _tripDto.Køretid * 7.70m;
                    return prisForKørerTiden + prisForKM + _tripDto.TurStartPris;
                }
                //hvis det er dag takst
                else if (_tripDto.Nattakst == false)
                {
                    prisprKM = 16m; //kr
                    _tripDto.TurStartPris = 57; //kr
                    var prisForKM = _tripDto.ForventetKørtKm * prisprKM;
                    var prisForKørerTiden = _tripDto.Køretid * 6.50m;
                    return prisForKørerTiden + prisForKM + _tripDto.TurStartPris;

                }
                else
                    return 0;
            }
            //hvis det er en lillevogn
            else if (_tripDto.Storvogn == false)
            {
                //hvis det er nat takst
                if (_tripDto.Nattakst == true)
                {
                    prisprKM = 16m; //kr
                    _tripDto.TurStartPris = 27; //kr
                    var prisForKM = _tripDto.ForventetKørtKm * prisprKM;
                    var prisForKørerTiden = _tripDto.Køretid * 7.50m;
                    return prisForKørerTiden + prisForKM + _tripDto.TurStartPris;
                }
                //hvis det er dag takst
                else if (_tripDto.Nattakst == false)
                {
                    prisprKM = 14m; //kr
                    _tripDto.TurStartPris = 27; //kr
                    var prisForKM = _tripDto.ForventetKørtKm * prisprKM;
                    var prisForKørerTiden = _tripDto.Køretid * 6.70m;
                    return prisForKørerTiden + prisForKM + _tripDto.TurStartPris;
                }
                else
                    return 0;
            }
            else
                return 0;
        }

        private decimal GadeTur()
        {
            //Hvis det er en storvogn
            if (_tripDto.Storvogn == true)
            {
                //hvis det er nat takst
                if (_tripDto.Nattakst == true)
                {
                    prisprKM = 18m; //kr
                    _tripDto.TurStartPris = 27; //kr
                    var prisForKM = _tripDto.ForventetKørtKm * prisprKM;
                    var prisForKørerTiden = _tripDto.Køretid * 6.50m;
                    return prisForKørerTiden + prisForKM + _tripDto.TurStartPris;
                }
                //hvis det er dag takst
                else if (_tripDto.Nattakst == false)
                {
                    prisprKM = 17m; //kr
                    _tripDto.TurStartPris = 27; //kr
                    var prisForKM = _tripDto.ForventetKørtKm * prisprKM;
                    var prisForKørerTiden = _tripDto.Køretid * 5.50m;
                    return prisForKørerTiden + prisForKM + _tripDto.TurStartPris;
                }
                else
                    return 0;
            }
            //hvis det er en lillevogn
            else if (_tripDto.Storvogn == false)
            {
                //hvis det er nat takst
                if (_tripDto.Nattakst == true)
                {
                    prisprKM = 16m; //kr
                    _tripDto.TurStartPris = 27; //kr
                    var prisForKM = _tripDto.ForventetKørtKm * prisprKM;
                    var prisForKørerTiden = _tripDto.Køretid * 6.50m;
                    return prisForKørerTiden + prisForKM + _tripDto.TurStartPris;
                }
                //hvis det er dag takst
                else if (_tripDto.Nattakst == false)
                {
                    prisprKM = 14m; //kr
                    _tripDto.TurStartPris = 27; //kr
                    var prisForKM = _tripDto.ForventetKørtKm * prisprKM;
                    var prisForKørerTiden = _tripDto.Køretid * 5.50m;
                    return prisForKørerTiden + prisForKM + _tripDto.TurStartPris;
                }
                else
                    return 0;
            }
            else
                return 0;
        }

    }
}
