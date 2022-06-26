using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadController : MonoBehaviour
{
    public int speed;
    public KeyCode key1;
    public KeyCode key2;
    private Rigidbody rig;
    public int controlType;
    public float moveLimit;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    void Update()
    {
        MoveObject(GetInput());
    }

    private Vector3 GetInput()
    {
        if (Input.GetKey(key1))
        {
            if (controlType == 1)
            {
                if (transform.position.x > -moveLimit)
                {
                    return Vector3.left * speed;
                }
                return Vector3.zero;
            }
            else if (controlType == 2)
            {
                if (transform.position.z < moveLimit)
                {
                    return Vector3.forward * speed;
                }
                return Vector3.zero;
            }
        }
        else if (Input.GetKey(key2))
        {
            if (controlType == 1)
            {
                if (transform.position.x < moveLimit)
                {
                    return Vector3.right * speed;
                }
                return Vector3.zero;
            }
            else if (controlType == 2)
            {
                if (transform.position.z > -moveLimit)
                {
                    return Vector3.back * speed;
                }
                return Vector3.zero;
            }
        }

        return Vector3.zero;
    }

    private void MoveObject(Vector3 movement)
    {
        rig.velocity = movement;
    }
}
