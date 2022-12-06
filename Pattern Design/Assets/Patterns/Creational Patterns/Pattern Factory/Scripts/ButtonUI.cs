using UnityEngine;

public class ButtonUI : MonoBehaviour
{
    [SerializeField] private CubeFactory _cubeFactory;
    [SerializeField] private CircleFactory _circleFactory;

    public void SpawnCubeButtonClick()
    {
        var prefab = _cubeFactory.GetNewInstance();
    }

    public void SpawnCircleButtonClick()
    {
        var prefab = _circleFactory.GetNewInstance();
    }
}