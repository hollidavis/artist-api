using System;
using System.Collections.Generic;
using artist_api.Models;

namespace artist_api.Services
{
    public class ArtistsService
    {
       internal IEnumerable<Artist> Get() {
       return FakeDB.Artists;
    }
     internal Artist Get(string id){
      Artist found = FakeDB.Artists.Find(c => c.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }

    internal Artist Create(Artist newArtist){
      FakeDB.Artists.Add(newArtist);
      return newArtist;
    }

    internal void Delete(string id){
      int deleted = FakeDB.Artists.RemoveAll(c => c.Id == id);
      if (deleted == 0){
        throw new Exception("Invalid Id");
      }
    }
    }
}