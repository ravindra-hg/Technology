using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcEntityframeworkAndProfiling.Models;

namespace MvcEntityframeworkAndProfiling.Repositories
{
    public class ArtistRepository : Repository<Artist>
    {
        public List<Artist> GetByName(string name)
        {
            return this.GetAll().Where(a => a.Name == name).ToList();
        }

    }
}