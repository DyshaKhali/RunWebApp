using RunCroopWebApp.Models;
using RunGroopWebApp.Data.Enum;

namespace RunCroopWebApp.ViewModels
{
    public class EditRaceViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public RaceCategory RaceCategory { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
