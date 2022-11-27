using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Pattern Singleton
    public static GameManager instance = null;
    private void Awake(){
        if (instance == null)
            instance = this;
    }
    #endregion

    public void ConsoleWriteLine(string text){
        Debug.Log(text);
    }
    public void ConsoleWriteLine(string text, string text1){
        Debug.Log(text + text1);
    }
    public void ConsoleWriteLine(string text, string text1 , string text2){
        Debug.Log(text + text1 + text2);
    }
}
