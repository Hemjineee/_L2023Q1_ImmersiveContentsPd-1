using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Receiver_VideoPlay : MonoBehaviour
{
    public GameObject Target;
    VideoPlayer Video;

    private void Start()
    {
        Video = Target.GetComponent<VideoPlayer>();
    }

    void DoSomething()
    {
        Video.Play();
        print("Video:" + Target.name + " Play");
    }
}
