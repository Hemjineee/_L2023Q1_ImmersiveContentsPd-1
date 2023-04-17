using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver_SetActiveTrue : MonoBehaviour
{
    public GameObject Target;

    void DoSomething()
    {
        Target.SetActive(true);
        print("SetActive:" + Target.name + " == " + Target.activeSelf);
    }
}
