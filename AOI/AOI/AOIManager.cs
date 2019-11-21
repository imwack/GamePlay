using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOI
{
    public class AOIManager:IAOIManager
    {
        private AOIDoubleLinkedList xList = new AOIDoubleLinkedList();
        private AOIDoubleLinkedList yList = new AOIDoubleLinkedList();
        private AOIDoubleLinkedList zList = new AOIDoubleLinkedList();
        private List<AOIEntity> entityList = new List<AOIEntity>();

        public float Radius { get; set; }

        public AOIManager(float radius)
        {
            Radius = radius;
        }

        //insert to list
        public void Enter(AOIEntity entity)
        {
            entityList.Add(entity);
            xList.Insert(entity.AoiNode);
            yList.Insert(entity.AoiNode);
            zList.Insert(entity.AoiNode);
            CheckEnterMyAoi(entity);
            CheckEnterOtherAoi(entity);
        }

        //remove from list
        public void Leave(AOIEntity entity)
        {
            entityList.Remove(entity);
        }

        //on entity move
        public void Move(AOIEntity entity, float x, float y, float z)
        {
        }

        private void CheckEnterOtherAoi(AOIEntity entity)
        {
            
        }

        private void CheckEnterMyAoi(AOIEntity entity)
        {
            
        }

    }
}
