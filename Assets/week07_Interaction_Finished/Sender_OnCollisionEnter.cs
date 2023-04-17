using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sender_OnCollisionEnter : MonoBehaviour
{
    public GameObject MessageReceiver;

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);
        if (collision.gameObject.name == "FPSController")
        {
            
            MessageReceiver.SendMessage("DoSomething");
        }
    }
}
