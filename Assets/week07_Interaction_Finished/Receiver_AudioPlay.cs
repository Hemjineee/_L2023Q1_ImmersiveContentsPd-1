using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver_AudioPlay : MonoBehaviour
{
    public GameObject Target;
    AudioSource Audio;

    private void Start()
    {
        Audio = Target.GetComponent<AudioSource>();
    }

    void DoSomething()
    {
        Audio.Play();
        print("Audio:" + Target.name + " Play");
    }
}
