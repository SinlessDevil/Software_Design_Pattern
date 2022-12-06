using UnityEngine;
using Prototype;

public class TestPrototype : MonoBehaviour
{
    public void Start()
    {
        ColorObjectsManager colorObjectsManager = new ColorObjectsManager();

        colorObjectsManager["Red"] = new ColorObject(Color.red);
        colorObjectsManager["Green"] = new ColorObject(Color.green);
        colorObjectsManager["Blue"] = new ColorObject(Color.blue);

        colorObjectsManager["Gray"] = new ColorObject(Color.gray);
        colorObjectsManager["White"] = new ColorObject(Color.white);
        colorObjectsManager["Black"] = new ColorObject(Color.black);

        ColorObject color1 = colorObjectsManager["Red"].Clone() as ColorObject;
        ColorObject color2 = colorObjectsManager["Black"].Clone() as ColorObject;
        ColorObject color3 = colorObjectsManager["White"].Clone() as ColorObject;

    }
}