using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver_SetActiveFalse : MonoBehaviour
{
    public GameObject Target;

    void DoSomething()
    {
        Target.SetActive(false);
        print("SetActive:" + Target.name + " == " + Target.activeSelf);
    }
}
