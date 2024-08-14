using Microsoft.AspNetCore.Mvc.Rendering;

namespace MovieStoreMvc.Models.Domain
{
    public class Place
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageFile { get; set; }
        public IEnumerable<SelectListItem> GenreList { get; set; }
        public int ReleaseYear { get; set; }
        public string Cast { get; set; }
        public string Description { get; set; }
        public IEnumerable<int> SelectedGenres { get; set; }
    }
}
