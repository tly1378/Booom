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
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityMouse, 0);
        camera.Rotate(-Input.GetAxis("Mouse Y") * sensitivityMouse,0,0);
        Vector3 direction = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            direction.z += 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction.x -= 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction.z -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction.x += 1;
        }
        rigidbody.AddForce(direction* MoveSpeed);
    }
}
