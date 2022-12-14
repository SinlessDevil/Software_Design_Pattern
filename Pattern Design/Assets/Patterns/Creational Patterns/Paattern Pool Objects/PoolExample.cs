using UnityEngine;

public class PoolExample : MonoBehaviour
{
    [SerializeField] private int poolCount = 3;
    [SerializeField] private bool autoExpand = false;
    [SerializeField] private ObjectPool objectPrefab;

    private PoolMono<ObjectPool> pool;

    private void Start()
    {
        this.pool = new PoolMono<ObjectPool>(this.objectPrefab, this.poolCount, this.transform);
        this.pool.autoExpand = this.autoExpand;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.CreateCube();
        }
    }

    private void CreateCube()
    {
        var rX = Random.Range(-5, 5);
        var rZ = Random.Range(-5, 5);
        var Y = 0;

        var rPosition = new Vector3(rX, Y, rZ);
        var cube = this.pool.GetFreeElement();
        cube.transform.position = rPosition;
    }
}

