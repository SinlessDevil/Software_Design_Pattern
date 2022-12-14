using System.Collections.Generic;

namespace CompositeAndVisitor
{
    public class Squad : ISelectableEntity
    {
        private List<ISelectableEntity> _unitsInSquad;

        public Squad()
        {
            _unitsInSquad = new List<ISelectableEntity>();
        }

        public Squad(List<ISelectableEntity> unitsInSquad)
        {
            _unitsInSquad = unitsInSquad;
        }

        public void AddUnityInSquad(ISelectableEntity entity)
        {
            _unitsInSquad.Add(entity);
        }

        public void Accept(ISelectableEntityVisitor visitor)
        {
            foreach (var unit in _unitsInSquad)
            {
                unit.Accept(visitor);
            }

            visitor.Visit(this);
        }

        public void MoveTo(int x, int y)
        {
            foreach (var unit in _unitsInSquad)
            {
                unit.MoveTo(x,y);
            }
        }
    }
}