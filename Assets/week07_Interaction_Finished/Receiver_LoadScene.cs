using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Receiver_LoadScene : MonoBehaviour
{
    public Object Scene;

    void DoSomething()
    {
        print("LoadScene:" + Scene.name);
        SceneManager.LoadScene(Scene.name.ToString());
    }
}
