using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportSimulator
{
    public interface IDriver
    {
        public void Navigate(string destination);
    }
}
