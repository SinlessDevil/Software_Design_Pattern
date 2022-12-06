using UnityEngine;

namespace AbstFactory
{
    public class ArcherFactory : AbstractFactory
    {
        private Transform _spawnPoint;

        public ArcherFactory(Transform spawnPoint)
        {
            _spawnPoint = spawnPoint;
        }

        public override GameObject CreateUnitStandard()
        {
            var standardArcherPrefab = Resources.Load<GameObject>("Archer");
            var standartArcher = Instantiate(standardArcherPrefab, _spawnPoint.position, Quaternion.identity);
            return standartArcher;
        }
    }
}