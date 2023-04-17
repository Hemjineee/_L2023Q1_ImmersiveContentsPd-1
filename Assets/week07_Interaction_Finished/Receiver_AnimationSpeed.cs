using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver_AnimationSpeed : MonoBehaviour
{
    public GameObject Target;
    Animator animator;
    public float speed = 0;

    private void Start()
    {
        animator = Target.GetComponent<Animator>();
    }

    void DoSomething()
    {
        animator.speed = speed; 
        print("Animation:" + Target.name + " Speed == " + speed);
    }
}
