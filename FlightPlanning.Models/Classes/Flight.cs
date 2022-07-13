using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanning.Models
{
    /*
     * TODO: https://app.goflightlabs.com/documentation#airports
     * possible api for flight information
     */

    public class Flight
    {
        public int FlightNumber { get; set; }
        public string Seat { get; set; }
        public string Status { get; set; }
        public string FlightDuration { get; set; }
        public string Delay { get; set; }
        public string AirlineName { get; set; }
        public Aircraft AircraftInformation { get; set; }

        //Departure airport
        public string DepartartureAirport { get; set; }
        public DateTimeOffset DepatartureDate { get; set; }
        public string DepatartureGate { get; set; }

        //Arrival airport
        public string ArrivalAirport { get; set; }
        public DateTimeOffset ArrivalDate { get; set; }
        public string ArrivalGate { get; set; }

        public Flight(int flightNumber, string seat, string status, string flightDuration, string delay, string airlineName, Aircraft aircraftInformation, string departartureAirport, DateTimeOffset depatartureDate, string depatartureGate, string arrivalAirport, DateTimeOffset arrivalDate, string arrivalGate)        {
            FlightNumber = flightNumber;
            Seat = seat;
            Status = status;
            FlightDuration = flightDuration;
            Delay = delay;
            AirlineName = airlineName;
            AircraftInformation = aircraftInformation;
            DepartartureAirport = departartureAirport;
            DepatartureDate = depatartureDate;
            DepatartureGate = depatartureGate;
            ArrivalAirport = arrivalAirport;
            ArrivalDate = arrivalDate;
            ArrivalGate = arrivalGate;
        }

    }
}
