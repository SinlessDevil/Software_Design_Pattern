using System.Collections;
using UnityEngine;

public sealed class Coroutines : MonoBehaviour
{
    private static Coroutines Instance{
        get {
            if (m_instance == null){
                var go = new GameObject("[COROUTINE NANAGER]");
                m_instance= go.AddComponent<Coroutines>();
                DontDestroyOnLoad(go);
            }
            return m_instance;
        }
    }
    private static Coroutines m_instance;

    public static Coroutine StartRoutine(IEnumerator enumerator){
        return Instance.StartCoroutine(enumerator);
    }

    public static void StopRoutine(Coroutine routine){
        Instance.StopCoroutine(routine);
    }
}