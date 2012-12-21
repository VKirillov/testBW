using System;
using System.Linq;
using SitefinityWebApp.Mvc.Models.Enums;

namespace SitefinityWebApp.Mvc.Models
{
    public class MainSearchModel
    {
        public string SearchString { get; set; }

        public DateTime CheckInDate { get; set; }

        public int NumberOfNights { get; set; }

        public HotelGlobalRegions SearchRegion { get; set; }
    }
}