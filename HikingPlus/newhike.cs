using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HikingPlus
{
    public class newhike
    {
        private string hikeName;
        private string hikeMiles;
        private string hikeHours;
        private DateTime hikeDate;
        private string hikeDifficulty;

        public string HikeName { get => hikeName; set => hikeName = value; }
        public string HikeMiles { get => hikeMiles; set => hikeMiles = value; }
        public string HikeHours { get => hikeHours; set => hikeHours = value; }
        public DateTime HikeDate { get => hikeDate; set => hikeDate = value; }
        public string HikeDifficulty { get => hikeDifficulty; set => hikeDifficulty = value; }

        public newhike() { }

        public newhike(string hikeName, string hikeMiles, string hikeHours, DateTime hikeDate, string hikeDifficulty)
        {
            this.HikeName = hikeName;
            this.HikeMiles = hikeMiles;
            this.HikeHours = hikeHours;
            this.HikeDate = hikeDate;
            this.HikeDifficulty = hikeDifficulty;
        }
    }
}
