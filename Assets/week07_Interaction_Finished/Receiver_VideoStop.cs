using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Receiver_VideoStop : MonoBehaviour
{
    public GameObject Target;
    VideoPlayer Video;

    private void Start()
    {
        Video = Target.GetComponent<VideoPlayer>();
    }

    void DoSomething()
    {
        Video.Stop();
        print("Video:" + Target.name + " Play");
    }
}
