using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOI
{
    public class AOIEntity
    {
        public ulong Id;
        public float X;
        public float Y;

        public AOIEntityDelegate OnEnter;
        public AOIEntityDelegate OnLeave;
        public AOIEntityDelegate OnSelfEnter;
        public AOIEntityDelegate OnSelfLeave;

        public Dictionary<ulong, AOIEntity> canViewEntityDic;

        public AOIEntity()
        {
            canViewEntityDic = new Dictionary<ulong, AOIEntity>();
        }

        public void OnMove(float x, float y, float z)
        {
            
        }

        public delegate void AOIEntityDelegate(AOIEntity aoiEntity);
    }
}
