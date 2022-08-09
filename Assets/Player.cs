using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed;
    public float sensitivityMouse;
    public new Transform camera;
    new Rigidbody rigidbody;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }


    float angle;
    public float angleLimit;
    private void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityMouse, 0);
        if (!((Input.GetAxis("Mouse Y") > 0 && angle > angleLimit) ||(Input.GetAxis("Mouse Y") < 0 && angle < -angleLimit)))
        {
            angle += Input.GetAxis("Mouse Y") * sensitivityMouse;
            camera.Rotate(-Input.GetAxis("Mouse Y") * sensitivityMouse,0,0);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            InteractableItem.target.Interact();
        }
    }

    public AudioSource source;
    void FixedUpdate()
    {
        Vector3 direction = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            direction += transform.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction -= transform.right;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction -= transform.forward;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += transform.right;
        }
        rigidbody.AddForce(MoveSpeed * direction);
        if (direction != Vector3.zero)
        {
            if (!source.isPlaying)
            {
                source.Play();
            }
        }
        else
        {
            if (source.isPlaying)
            {
                source.Pause();
            }
        }
    }
}
