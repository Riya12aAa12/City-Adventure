using Microsoft.AspNetCore.Mvc;
using MovieStoreMvc.Repositories.Abstract;

public class PlaceController : Controller
{
    private readonly IPlaceService _placeService;
    private readonly IFileService _fileService;
    private readonly IGenreService _genService;

    public PlaceController(IGenreService genService, IPlaceService placeService, IFileService fileService)
    {
        _placeService = placeService;
        _fileService = fileService;
        _genService = genService;
    }

    // Existing methods...

    public IActionResult Index()
    {
        var data = _placeService.List(); // Fetch all places
        return View(data); // Return the list of places to the view
    }

    // Other actions...
}
