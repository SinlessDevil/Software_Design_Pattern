using System.Collections;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private float lifetime = 2f;

    private void OnEnable()
    {
        StartCoroutine("StartLifeRoutine");
        Debug.Log("OnEnable");
    }

    private void OnDisable()
    {
        this.StopCoroutine("StartLifeRoutine");
        Debug.Log("OnDisable");
    }

    IEnumerator StartLifeRoutine()
    {
        Debug.Log("StartCoroutine");
        yield return new WaitForSecondsRealtime(this.lifetime);
        this.Deactivate();
    }

    private void Deactivate()
    {
        Debug.Log("Deactivate");
        this.gameObject.SetActive(false);
    }
}
