using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataToJsonAdapter
{
    public interface ITarget
    {
        string ReadDataFromSource();
    }
}
