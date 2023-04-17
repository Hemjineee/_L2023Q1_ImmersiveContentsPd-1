using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Receiver_InstantiateGameObject : MonoBehaviour
{
    public GameObject Target;
    public float DestroyDelay = -1;

    void DoSomething()
    {
        print("Instantiate:" + Target.name);
        GameObject Clone = Instantiate(Target);
        if(DestroyDelay > 0)
        {
            Destroy(Clone, DestroyDelay);
        }
    }
}
