using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sender_OnTriggerEnter : MonoBehaviour
{
    public GameObject MessageReceiver;

    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name);
        if (other.gameObject.name == "FPSController")
        {
            MessageReceiver.SendMessage("DoSomething");
        }
    }
}
