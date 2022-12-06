using UnityEngine;

[CreateAssetMenu(menuName = "Weapon Data")]
public class WeaponData : ScriptableObject
{
    public int damage;
    public string massage;
    public GameObject model;
    public int stunDuration;
    public int freezeDuration;
}