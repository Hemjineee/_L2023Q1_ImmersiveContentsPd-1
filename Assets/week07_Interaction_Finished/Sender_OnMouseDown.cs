using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sender_OnMouseDown : MonoBehaviour
{
    public GameObject MessageReceiver;

    private void OnMouseDown()
    {
        MessageReceiver.SendMessage("DoSomething");
    }
}
