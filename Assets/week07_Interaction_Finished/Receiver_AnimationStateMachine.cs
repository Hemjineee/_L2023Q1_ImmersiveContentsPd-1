using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver_AnimationStateMachine : MonoBehaviour
{
    public GameObject Target;
    Animator animator;
    public int State = 0;

    private void Start()
    {
        animator = Target.GetComponent<Animator>();
    }

    void DoSomething()
    {
        animator.SetInteger("State", State);
        print("Animation:" + Target.name + " State == " + State);
    }
}
