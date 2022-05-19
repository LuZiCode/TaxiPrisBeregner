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

        public decimal EkstraStopBeregner()
        {
            decimal AntalEkstra = _tripGetE.EkstraDistance;
            decimal PrisPrEkstraStop = 100;

            if (AntalEkstra < 1)
            {
                return 0;
            }
            else
            {
                return AntalEkstra * PrisPrEkstraStop;
            }
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
            if (!_tripGetE.Storvogn == true)
            {
                return SedanBeregner();
            }
            else return 0;
        }

        //SEDAN TJEKKER KM UDREGNERE
        /////////////////////////////////////////////////
        private decimal SedanBeregner()
        {
            if (_tripGetE.ForventetKørtKm > 100)
            {
                decimal result = DistanceFrom100_Sedan();
                result += DistanceBetween50and100_Sedan();
                result += DistanceBetween15and50_Sedan();
                result += DistanceBetween5and15_Sedan();
                result += DistanceBetween0and5_Sedan();

                return result;
            }

            else if (_tripGetE.ForventetKørtKm > 50)
            {
                decimal result = DistanceBetween50and100_Sedan();
                result += DistanceBetween15and50_Sedan();
                result += DistanceBetween5and15_Sedan();
                result += DistanceBetween0and5_Sedan();

                return result;
            }

            else if (_tripGetE.ForventetKørtKm > 15)
            {
                decimal result = DistanceBetween15and50_Sedan();
                result += DistanceBetween5and15_Sedan();
                result += DistanceBetween0and5_Sedan();
                return result;
            }

            else if (_tripGetE.ForventetKørtKm > 5)
            {
                decimal result = DistanceBetween5and15_Sedan();
                result += DistanceBetween0and5_Sedan();
                return result;
            }

            else if (_tripGetE.ForventetKørtKm >= 0)
            {

                return DistanceBetween0and5_Sedan(); ;
            }
            else return 0;
        }

        //SEDAN INDIVIDUELLE KM UDREGNERE
        /////////////////////////////////////////////////

        private decimal DistanceBetween0and5_Sedan()
        {
            prisprKM = 37m;
            decimal result = 0;
            if (_tripGetE.ForventetKørtKm > 5)
            {
                result = 5;
            }
            else
            {
                result = _tripGetE.ForventetKørtKm;
            }
            result = result * prisprKM;
            return result;
        }


        private decimal DistanceBetween5and15_Sedan()
        {
            prisprKM = 12m;
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

        private decimal DistanceBetween15and50_Sedan()
        {
            prisprKM = 10m;
            decimal result = 0;
            if (_tripGetE.ForventetKørtKm > 50)
            {
                result = 35;
            }
            else
            {
                result = _tripGetE.ForventetKørtKm - 15;
            }

            result = result * prisprKM;
            return result;
        }

        private decimal DistanceBetween50and100_Sedan()
        {
            prisprKM = 8m;
            decimal result = 0;
            if (_tripGetE.ForventetKørtKm > 100)
            {
                result = 50;
            }
            else
            {
                result = _tripGetE.ForventetKørtKm - 50;
            }

            result = result * prisprKM;
            return result;
        }

        private decimal DistanceFrom100_Sedan()
        {
            prisprKM = 10m;
            decimal result = 0;
            if (_tripGetE.ForventetKørtKm > 100)
            {
                result = _tripGetE.ForventetKørtKm - 100;
            }
            else
            {
                result = _tripGetE.ForventetKørtKm;
            }
            result = result * prisprKM;
            return result;
        }


        //MINIVAN TJEKKER KM UDREGNER
        /////////////////////////////////////////////////

        public decimal MiniVanBeregner()
        {
            if (_tripGetE.ForventetKørtKm > 100)
            {
                decimal result = DistanceFrom100_Minivan();
                result += DistanceBetween50and100_Minivan();
                result += DistanceBetween15and50_Minivan();
                result += DistanceBetween5and15_Minivan();
                result += DistanceBetween0and5_Minivan();

                return result;
            }

            else if (_tripGetE.ForventetKørtKm > 50)
            {
                decimal result = DistanceBetween50and100_Minivan();
                result += DistanceBetween15and50_Minivan();
                result += DistanceBetween5and15_Minivan();
                result += DistanceBetween0and5_Minivan();

                return result;
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
                decimal result = DistanceBetween5and15_Minivan();
                result += DistanceBetween0and5_Minivan();
                return result;
            }

            else if (_tripGetE.ForventetKørtKm >= 0)
            {
                
                return DistanceBetween0and5_Minivan(); ;
            }
            else return 0;
        }

        //MINIVAN INDIVIDUELLE KM UDREGNERE
        /////////////////////////////////////////////////

        private decimal DistanceBetween0and5_Minivan()
        {
            prisprKM = 49.2m;
            decimal result = 0;
            if (_tripGetE.ForventetKørtKm > 5)
            {
                result = 5;
            }
            else
            {
                result = _tripGetE.ForventetKørtKm;
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
                result = 35;
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
                result = 50;
            }
            else
            {
                result = _tripGetE.ForventetKørtKm - 50;
            }

            result = result * prisprKM;
            return result;
        }

        private decimal DistanceFrom100_Minivan()
        {
            prisprKM = 13m;
            decimal result = 0;
            if (_tripGetE.ForventetKørtKm > 100)
            {
                result = _tripGetE.ForventetKørtKm - 100;
            }
            else
            {
                result = _tripGetE.ForventetKørtKm;
            }
            result = result * prisprKM;
            return result;
        }
    }
}
