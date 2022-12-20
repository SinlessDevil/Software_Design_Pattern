using UnityEngine;

namespace ChainOfResponsibility
{
    public class MoveToPosition : GameHandler
    {
        public bool moveToPosition = false;
        [SerializeField] private Vector2 positionToMove;

        private void Update(){
            if (moveToPosition){
                transform.position = Vector2.MoveTowards(transform.position, positionToMove, Time.deltaTime * 3);
                if (Vector2.Distance(transform.position, positionToMove) == 0){
                    FinishedMoving();
                }
            }
        }

        private void FinishedMoving()
        {
            Debug.Log("The object reached its position");
            moveToPosition = false;
            base.Handler(null);
        }

        public override object Handler(object request)
        {
            moveToPosition = true;
            return null;
        }
    }
}