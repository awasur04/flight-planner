using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanning.Models
{
    /*TODO: https://rapidapi.com/aedbx-aedbx/api/aerodatabox/pricing

    */
    public class Aircraft
    {
        public string ICAOHex { get; set; }
        public string FlightModel { get; set; }
        public string EngineType { get; set; }
        public int SeatCount { get; set; }
        public DateTimeOffset DeliveryDate { get; set; }
        public int PlaneAge { get; set; }
        public string ImageURL { get; set; }

        public Aircraft(string iCAOHex, string flightModel, string engineType, int seatCount, DateTimeOffset deliveryDate, int planeAge, string imageURL)
        {
            ICAOHex = iCAOHex;
            FlightModel = flightModel;
            EngineType = engineType;
            SeatCount = seatCount;
            DeliveryDate = deliveryDate;
            PlaneAge = planeAge;
            ImageURL = imageURL;
        }
    }
}
