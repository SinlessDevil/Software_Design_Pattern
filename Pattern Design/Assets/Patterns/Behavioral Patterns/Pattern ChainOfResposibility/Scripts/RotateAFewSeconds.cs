using System.Collections;
using UnityEngine;

namespace ChainOfResponsibility
{
    public class RotateAFewSeconds : GameHandler
    {
        [SerializeField] private float rotationSpeed = 10.0f;
        [SerializeField] private float rotationDuration = 3.0f;
        private bool rotating;

        private void Update(){
            if (rotating){
                transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
            }
        }
        private IEnumerator StartRotating()
        {
            rotating = true;
            yield return new WaitForSeconds(rotationDuration);
            Debug.Log("The object has finished rotating its position");
            rotating = false;
            base.Handler(null);
        }
        public override object Handler(object request)
        {
            StartCoroutine(StartRotating());
            return null;
        }
    }
}