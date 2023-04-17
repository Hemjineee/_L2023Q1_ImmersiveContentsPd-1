using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample_SendMessage_Sender : MonoBehaviour
{
    public GameObject MessageReceiver;
    public string FunctionName;

    // Start is called before the first frame update
    void Start()
    {
        MessageReceiver.SendMessage("ReceiverFunction");        

        MessageReceiver.SendMessage("ReceiverFunction", 123);

        MessageReceiver.SendMessage(FunctionName);
    }
}
