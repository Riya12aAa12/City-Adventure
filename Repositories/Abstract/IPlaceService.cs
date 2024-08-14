using System.Collections.Generic;
using MovieStoreMvc.Models.Domain;

public interface IPlaceService
{
    IEnumerable<Place> List(); // Method to get all places
    Place GetById(int id);     // Method to get a place by its ID
    bool Add(Place place);    // Method to add a new place
    bool Update(Place place); // Method to update an existing place
    bool Delete(int id);      // Method to delete a place by its ID
    IEnumerable<int> GetGenresByPlaceId(int id); // Method to get genre IDs associated with a place
}
