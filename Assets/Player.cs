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
        Cursor.visible = false;
    }
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityMouse, 0);
        camera.Rotate(-Input.GetAxis("Mouse Y") * sensitivityMouse,0,0);
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
        rigidbody.AddForce(direction* MoveSpeed);
    }
}
