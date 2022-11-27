using UnityEngine;

public class Test : MonoBehaviour{
    private void Update(){
        if (Input.GetKeyDown(KeyCode.Q))
            GameManager.instance.ConsoleWriteLine("Helloy", " ", "World");
        if (Input.GetKeyDown(KeyCode.A))
            GameManager.instance.ConsoleWriteLine("UFO", " ", "UFO");
    }
}
