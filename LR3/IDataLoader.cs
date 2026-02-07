using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LR3
{
    interface IDataLoader
    {
        Dictionary<string, List<Dish>> LoadData();
    }
}
