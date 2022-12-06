using UnityEngine;

namespace PrototypeV2
{
    public class Weapon : MonoBehaviour
    {
        [SerializeField] private WeaponData _weaponData;

        [SerializeField] private Transform _weaponModelPosInParent;

        private GameObject _model;

        private void OnEnable()
        {
            if (_model != null) Destroy(_model);

            if (_weaponData.model != null)
            {
                _model = Instantiate(_weaponData.model);
                _model.transform.SetParent(_weaponModelPosInParent, false);
            }
        }

        public void Attack(Target targer)
        {
            if(_weaponData.damage > 0)
            {
                targer.TakeDamage(_weaponData.damage);
                targer.Freeze(_weaponData.freezeDuration);
                targer.Freeze(_weaponData.stunDuration);
            }
        }
    }
}