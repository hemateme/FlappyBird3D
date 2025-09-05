using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
    [Header("References")] 
    [SerializeField] private Rigidbody rb;
    [SerializeField] private GameEventSo gameOverGameEvent;
    
    [Header("Jump Settings")]
    [SerializeField] private float jumpStrength = 5f;
    [SerializeField] private float gravityScale = 2f;
    
    private InputAction _jumpAction;

    private void Start()
    { 
         Physics.gravity *= gravityScale;
    }

    public void OnJump()
    {
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, jumpStrength, rb.linearVelocity.z);           

    }


    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("OnCollisionEnter");
        gameOverGameEvent.Raise();
    }
}
