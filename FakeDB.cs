using System.Collections.Generic;
using artist_api.Models;

namespace artist_api
{
  static public class FakeDB
  {
    static public List<Artist> Artists { get; set; } = new List<Artist>() { new Artist("Vincent van Gogh ", "Oil Painting") };
  }
}