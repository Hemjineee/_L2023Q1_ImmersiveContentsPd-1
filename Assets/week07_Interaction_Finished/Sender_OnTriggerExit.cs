using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sender_OnTriggerExit : MonoBehaviour
{
    public GameObject MessageReceiver;

    private void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name);
        if (other.gameObject.name == "FPSController")
        {
            MessageReceiver.SendMessage("DoSomething");
        }
    }
}
