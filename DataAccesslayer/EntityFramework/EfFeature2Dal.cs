using DataAccesslayer.Abstract;
using DataAccesslayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesslayer.EntityFramework
{
    internal class EfFeature2Dal : GenericRepository<Feature2>, IFeature2Dal
    {
    }
}
