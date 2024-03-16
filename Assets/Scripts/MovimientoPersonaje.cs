using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movimiento : MonoBehaviour
{
    public float moveSpeed = 5f; 
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        Vector3 movement = Vector3.zero;
        if(Input.GetKey(KeyCode.W))
        {
            movement += transform.forward;
             Debug.Log("La pildora se esta moviendo hacia adelante!");
        }
        if(Input.GetKey(KeyCode.A))
        {
            movement -= transform.right;
             Debug.Log("La pildora se esta moviendo hacia izquierda!");
        }
        if(Input.GetKey(KeyCode.S))
        {
            movement -= transform.forward;
            Debug.Log("La pildora se esta moviendo hacia atras!");
        }
        if(Input.GetKey(KeyCode.D))
        {
            movement += transform.right;
             Debug.Log("La pildora se esta moviendo hacia derecha!");
        }
        if(movement.magnitude > 1f)
        {
            movement.Normalize();
        }
        rb.AddForce(movement * moveSpeed, ForceMode.Acceleration);
        rb.MovePosition(rb.position + rb.velocity * Time.fixedDeltaTime);
    }
}

