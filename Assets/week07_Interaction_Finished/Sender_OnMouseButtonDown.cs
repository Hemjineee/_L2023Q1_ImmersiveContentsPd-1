using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sender_OnMouseButtonDown : MonoBehaviour
{
    public int MouseButton;
    public GameObject MessageReceiver;
    //public string FunctionName;

    void Update()
    {
        if (Input.GetMouseButtonDown(MouseButton))
        {
            //if (string.IsNullOrEmpty(FunctionName))
            //{
            //    FunctionName = "DoSomething";
            //}
            //MessageReceiver.SendMessage(FunctionName);
            MessageReceiver.SendMessage("DoSomething");
        }
    }
}
