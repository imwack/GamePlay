using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOI
{
    public interface IAOIManager
    {

        void Enter(AOIEntity entity);
        void Leave(AOIEntity entity);
        void Move(AOIEntity entity, float x, float y, float z);
        float Radius { get; set; }

    }
}
