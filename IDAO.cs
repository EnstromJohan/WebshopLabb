using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopLabb
{
    internal interface IDAO
    {
        void Create(FilmsODM films);

        List<FilmsODM> ReadAll();

        void Update(string Title, string Director, string Genre, int Price);
        void Delete(ObjectId id);
    }
}
