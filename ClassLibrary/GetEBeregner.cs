using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class GetEBeregner
    {
        private readonly TripDto _tripDto;
        private decimal prisprKM = 0;
        private decimal priceØresund = 390;
        private decimal priceStorebælt = 490;
        private decimal priceMeetGreet = 100;


        public GetEBeregner(TripDto tripDto)
        {
            _tripDto = tripDto;
            StorEllerLilleVogn();
            TillægBerenger();
        }

        public decimal TillægBerenger()
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
            if (_tripDto.ValgteTillæg.Contains(Tillæg.MeetGreet))
            {
                result += priceMeetGreet;
            }

            return result;
        }

        public decimal StorEllerLilleVogn()
        {
            if (_tripDto.Storvogn == true)
            {
                return MiniVanBeregner();
            }
            if (_tripDto.Storvogn == false)
            {
                return SedanBeregner();
            }
            else return 0;
        }

        public decimal MiniVanBeregner()
        {
            decimal res = 0;
            if (_tripDto.ForventetKørtKm > 100)
            {
                res = DistanceBetween0and5_Minivan() + DistanceBetween5and15_Minivan() + DistanceBetween15and50_Minivan() + DistanceBetween50and100_Minivan() + DistanceFrom100_Minivan();
            }

            else if (_tripDto.ForventetKørtKm > 50)
            {
                res = DistanceBetween0and5_Minivan() + DistanceBetween5and15_Minivan() + DistanceBetween15and50_Minivan() + DistanceBetween50and100_Minivan();
            }

            else if (_tripDto.ForventetKørtKm > 15)
            {
                res = DistanceBetween0and5_Minivan() + DistanceBetween5and15_Minivan() + DistanceBetween15and50_Minivan();
            }

            else if (_tripDto.ForventetKørtKm > 5)
            {
                res = DistanceBetween0and5_Minivan() + DistanceBetween5and15_Minivan();
            }

            else if (_tripDto.ForventetKørtKm > 0)
            {
                res = DistanceBetween0and5_Minivan();
            }
            return res;
        }


        private decimal DistanceBetween0and5_Minivan()
        {
            prisprKM = 69;

            if (_tripDto.ForventetKørtKm > 5)
                _tripDto.ForventetKørtKm = 5;
            else
                _tripDto.ForventetKørtKm -= 0;

            return _tripDto.ForventetKørtKm * prisprKM;
        }

        private decimal DistanceBetween5and15_Minivan()
        {
            prisprKM = 16;

            if (_tripDto.ForventetKørtKm > 15)
                _tripDto.ForventetKørtKm = 10;
            else
                _tripDto.ForventetKørtKm -= 5;

            return _tripDto.ForventetKørtKm * prisprKM;
        }
        private decimal DistanceBetween15and50_Minivan()
        {
            prisprKM = 13;

            if (_tripDto.ForventetKørtKm > 50)
                _tripDto.ForventetKørtKm = 35;
            else
                _tripDto.ForventetKørtKm -= 15;

            return _tripDto.ForventetKørtKm * prisprKM;
        }

        private decimal DistanceBetween50and100_Minivan()
        {
            prisprKM = 11;

            if (_tripDto.ForventetKørtKm > 100)
                _tripDto.ForventetKørtKm = 50;
            else
                _tripDto.ForventetKørtKm -= 50;

            return _tripDto.ForventetKørtKm * prisprKM;
        }

        private decimal DistanceFrom100_Minivan()
        {
            prisprKM = 13;
            _tripDto.ForventetKørtKm -= 100;
            return _tripDto.ForventetKørtKm * prisprKM;
        }

        public decimal SedanBeregner()
        {
            return 0;
        }
    }
}
