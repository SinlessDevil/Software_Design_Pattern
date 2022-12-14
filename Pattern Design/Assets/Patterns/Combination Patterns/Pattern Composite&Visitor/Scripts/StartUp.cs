using System.Collections.Generic;
using UnityEngine;

namespace CompositeAndVisitor
{
    public class StartUp : MonoBehaviour
    {
        private void Start()
        {
            var squad = new Squad();
            squad.AddUnityInSquad(new Unit(10));
            squad.AddUnityInSquad(new Unit(15));
            squad.AddUnityInSquad(new Unit(16));
            squad.AddUnityInSquad(new Unit(35));
            //----------------------------------
            squad.AddUnityInSquad(new Squad(new List<ISelectableEntity>()
            {
                new Unit(5), new Unit(5), new Unit(5)
            }));
            //-------------------------------------------------------------
            ISelectableEntity entity = squad;
            squad.MoveTo(10, 10);
            //-------------------------------
            var health = new UnitHealth();
            entity.Accept(health);
            Debug.Log(health.Result);
        }
    }
}