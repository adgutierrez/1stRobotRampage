using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;

    
    Rigidbody myRigidbody;
    InputValue value;
    Vector3 rawInput;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        rawInput = value.Get<Vector3>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 vector3 = moveSpeed * Time.deltaTime * rawInput;
        myRigidbody.velocity = rawInput;
    }

}
