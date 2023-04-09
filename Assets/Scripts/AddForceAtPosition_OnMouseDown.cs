using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceAtPosition_OnMouseDown : MonoBehaviour
{
    Rigidbody rb;
    public float forceAmount = 300f;
    public Transform ForceStartPoint;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (transform.position.y < -1)
        {
            transform.position = new Vector3(0, 0.5f, -10);
            rb.angularVelocity = Vector3.zero;
            rb.velocity = Vector3.zero;
            transform.rotation = Quaternion.identity;
        }
    }

    private void OnMouseDown()
    {
        var Dir = transform.position - ForceStartPoint.position;
        rb.AddForceAtPosition(Dir * forceAmount, ForceStartPoint.position);
    }
}
