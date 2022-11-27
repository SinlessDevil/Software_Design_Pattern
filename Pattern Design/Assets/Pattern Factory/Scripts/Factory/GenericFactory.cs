using UnityEngine;

public class GenericFactory<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField] private T _prefab;
    [SerializeField] private Transform _pointToSpawn;
    private int _offset = 0;

    public T GetNewInstance()
    {
        Vector3 pos = new Vector3(_pointToSpawn.position.x, _prefab.transform.position.y, _pointToSpawn.position.z + _offset);

        _offset++;

        return Instantiate(_prefab, pos, Quaternion.identity);
    }
}
