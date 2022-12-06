using UnityEngine;
using AbstFactory;

public class TestFactory : MonoBehaviour
{
    private AbstractFactory _factory;
    public void SpawnArcher(Transform spawnPosArcher)
    {
        _factory = new ArcherFactory(spawnPosArcher);
        _factory.CreateUnitStandard();
    }

    public void SpawnWarrior(Transform spawnPosArcher)
    {
        _factory = new WarriorFactory(spawnPosArcher);
        _factory.CreateUnitStandard();
    }
}