using UnityEngine;

namespace AbstFactory
{
    public class WarriorFactory : AbstractFactory
    {
        private Transform _spawnPoint;

        public WarriorFactory(Transform spawnPoint)
        {
            _spawnPoint = spawnPoint;
        }

        public override GameObject CreateUnitStandard()
        {
            var standardArcherPrefab = Resources.Load<GameObject>("Warrior");
            var standartArcher = Instantiate(standardArcherPrefab, _spawnPoint.position, Quaternion.identity);
            return standartArcher;
        }
    }
}