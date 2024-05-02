using RunCroopWebApp.Data.Enum;
using RunCroopWebApp.Models;

namespace RunCroopWebApp.ViewModels
{
    public class EditClubViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public ClubCategory ClubCategory { get; set; }
        public int? AddressId { get; set; }
        public Address Address { get; set; }
    }
}
