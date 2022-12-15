using UnityEngine;

public class StartUpTest : MonoBehaviour
{
    private void Start()
    {
        var woodBuilding = new DescriptionWoodBuilding();

        var defaultDecorator = new DefaultDescriptionBuilding(woodBuilding);
        var levelDecorator = new LevelDescriptionBuilding(woodBuilding, 10);

        print(defaultDecorator.GetDescription());
        print(levelDecorator.GetDescription());
    }
}
