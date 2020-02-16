using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Redesign
{
    public interface ITempSensor
    {
        int GetTemp();

        bool RunSelfTest();
    }
}
