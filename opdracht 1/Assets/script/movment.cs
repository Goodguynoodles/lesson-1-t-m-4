using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment : MonoBehaviour
{
    public float speed = 100.0f;
    public float turnspeed = 45.0f;
    private float forward;
    private float horizontalInput;
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        forward = Input.GetAxisRaw("Vertical");
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forward);
        transform.Rotate(Vector3.up, turnspeed * horizontalInput * Time.deltaTime);
    }
}
