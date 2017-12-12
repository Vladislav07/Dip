using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkadTechDomain.Abstract
{
    interface IitemZsRepository
    {
        IQueryable<ItemZs>ListItemZs { get; }
    }
}
