using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample_SendMessage_Receiver : MonoBehaviour
{
    public void ReceiverFunction()
    {
        print("This is Receiver Function");
    }

    public void ReceiverFunction(int i)
    {
        print("This is Receiver Function with Options:" + i);
    }

    public void ReceiverFunction1()
    {
        print("This is Receiver Function1");
    }
}
