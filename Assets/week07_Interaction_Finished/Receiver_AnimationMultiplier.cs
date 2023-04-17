using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver_AnimationMultiplier : MonoBehaviour
{
    public GameObject Target;
    Animator animator;
    public float multiplier = 0;

    private void Start()
    {
        animator = Target.GetComponent<Animator>();
    }

    void DoSomething()
    {
        animator.SetFloat("Multiplier", multiplier);
        print("Animation:" + Target.name + " Multiplier == " + multiplier);
    }
}
