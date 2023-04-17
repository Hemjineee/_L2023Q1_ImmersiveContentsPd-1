using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sender_OnButtonDown : MonoBehaviour
{
    public GameObject MessageReceiver;

    public void DoSomething()
    {
        MessageReceiver.SendMessage("DoSomething");
    }
}
