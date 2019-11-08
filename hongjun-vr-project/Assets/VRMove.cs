using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRMove : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody rigid;

    // Update is called once per frame
    void Update()
    {
        Vector3 move = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
        rigid.MovePosition(transform.position + move * speed * Time.deltaTime);
    }
}
