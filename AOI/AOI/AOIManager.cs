using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOI
{
    public class AOIManager:IAOIManager
    {
        private LinkedList<ulong> xList = new LinkedList<ulong>();
        private LinkedList<ulong> yList = new LinkedList<ulong>();
        private LinkedList<ulong> zList = new LinkedList<ulong>();

        public float Radius { get; set; }

        public AOIManager(float radius)
        {
            Radius = radius;
        }

        public void Enter(AOIEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Leave(AOIEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Move(AOIEntity entity, float x, float y, float z)
        {
            throw new NotImplementedException();
        }


    }
}
