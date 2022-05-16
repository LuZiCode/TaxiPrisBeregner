using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class GetEBeregner
    {
        private readonly TripDtoGetE _tripGetE;
        private decimal prisprKM = 0;
        private decimal priceØresund = 390;
        private decimal priceStorebælt = 490;
        private decimal priceMeetGreet = 100;

        //Tillæg Beregner
        public GetEBeregner(TripDtoGetE tripDto)
        {
            _tripGetE = tripDto;
            //StorEllerLilleVogn();
            //TillægBerenger();
        }


        public decimal TillægBerenger()
        {
            decimal result = 0;
            if (_tripGetE.ValgteTillæg.Contains(TillægGetE.Øresund))
            {
                result += priceØresund;
            }
            if (_tripGetE.ValgteTillæg.Contains(TillægGetE.Storebælt))
            {
                result += priceStorebælt;
            }
            if (_tripGetE.ValgteTillæg.Contains(TillægGetE.MeetGreet))
            {
                result += priceMeetGreet;
            }

            return result;
        }

        public decimal StorEllerLilleVogn()
        {
            if (_tripGetE.Storvogn == true)
            {
                return MiniVanBeregner();
            }
            if (_tripGetE.Storvogn == false)
            {
                return SedanBeregner();
            }
            else return 0;
        }

        private decimal SedanBeregner()
        {
            return 0;
        }

        public decimal MiniVanBeregner()
        {
            if (_tripGetE.ForventetKørtKm > 100)
            {
                var result = DistanceFrom100_Minivan();
                result += DistanceBetween50and100_Minivan();
                result += DistanceBetween15and50_Minivan();
                result += DistanceBetween5and15_Minivan();
                result += DistanceBetween0and5_Minivan();

                return result;
            }

            else if (_tripGetE.ForventetKørtKm > 50)
            {
                return DistanceBetween50and100_Minivan() + DistanceBetween15and50_Minivan() + DistanceBetween5and15_Minivan() + DistanceBetween0and5_Minivan();
            }

            else if (_tripGetE.ForventetKørtKm > 15)
            {
                decimal result = DistanceBetween15and50_Minivan();
                result += DistanceBetween5and15_Minivan();
                result += DistanceBetween0and5_Minivan();
                return result;
            }

            else if (_tripGetE.ForventetKørtKm > 5)
            {
                var result = DistanceBetween5and15_Minivan();
                result += DistanceBetween0and5_Minivan();
                return result;
            }

            else if (_tripGetE.ForventetKørtKm > 0)
            {
                return DistanceBetween0and5_Minivan();
            }
            else return 0;
        }

        /////////////////////////////////////////////////

        private decimal DistanceBetween0and5_Minivan()
        {
            prisprKM = 69m;
            decimal result = 0;
            if (_tripGetE.ForventetKørtKm > 5)
            {
                result = 5;
            }

            result = result * prisprKM;
            return result;
        }

        private decimal DistanceBetween5and15_Minivan()
        {
            prisprKM = 16m;
            decimal result = 0;
            if (_tripGetE.ForventetKørtKm > 15)
            {
                result = 10; //result sættes til 10 km da 15 - 5 = 10
                //HVad gør du hvis den er 14 -5 = 9
            }
            else
            {
               result = _tripGetE.ForventetKørtKm - 5;
            }

            result = result * prisprKM;
            return result;
        }

        private decimal DistanceBetween15and50_Minivan()
        {
            prisprKM = 13m;
            decimal result = 0;
            if (_tripGetE.ForventetKørtKm > 50)
            {
                _tripGetE.ForventetKørtKm = 35;
            }
            else
            {
                result = _tripGetE.ForventetKørtKm - 15;
            }

            result = result * prisprKM;
            return result;
        }

        private decimal DistanceBetween50and100_Minivan()
        {
            prisprKM = 11m;
            decimal result = 0;
            if (_tripGetE.ForventetKørtKm > 100)
            {
                _tripGetE.ForventetKørtKm = 50;
            }
            else
            {
                _tripGetE.ForventetKørtKm -= 50;
            }

            result = _tripGetE.ForventetKørtKm * prisprKM;
            return result;
        }

        private decimal DistanceFrom100_Minivan()
        {
            prisprKM = 13m;
            decimal result = 0;
            if (_tripGetE.ForventetKørtKm > 100)
            {
                _tripGetE.ForventetKørtKm -= 100;
            }

            result = _tripGetE.ForventetKørtKm * prisprKM;
            return result;
        }
    }
}
