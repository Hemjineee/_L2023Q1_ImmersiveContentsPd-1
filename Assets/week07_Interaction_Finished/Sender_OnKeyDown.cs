using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sender_OnKeyDown : MonoBehaviour
{
    public string Key;
    public GameObject MessageReceiver;
    //public string FunctionName;    

    void Update()
    {
        if (Input.anyKeyDown)
        {
            if(Input.inputString.ToLower() == Key.ToLower())
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
}
