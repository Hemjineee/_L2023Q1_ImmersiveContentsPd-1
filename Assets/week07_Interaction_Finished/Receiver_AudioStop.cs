using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver_AudioStop : MonoBehaviour
{
    public GameObject Target;
    AudioSource Audio;

    private void Start()
    {
        Audio = Target.GetComponent<AudioSource>();
    }

    void DoSomething()
    {
        Audio.Stop();
        print("Audio:" + Target.name + " Stop");
    }
}
