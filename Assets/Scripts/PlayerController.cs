using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
    [Header("References")] 
    [SerializeField] private Rigidbody rb;
    [SerializeField] private GameEventSo gameOverGameEvent;
    [SerializeField] private GameEventSo increaseScoreGameEvent;
    
    [Header("Jump Settings")]
    [SerializeField] private float jumpStrength = 5f;
    [SerializeField] private float gravityScale = 2f;
    
    private InputAction _jumpAction;
    private bool _isDead = false;

    private void Start()
    { 
         Physics.gravity *= gravityScale;
    }

    public void OnJump()
    {
        if (_isDead) return;
        
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, jumpStrength, rb.linearVelocity.z);           

    }
    
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("OnCollisionEnter");
        gameOverGameEvent.Raise();
        _isDead = true;
    }

    private void OnTriggerExit(Collider other)
    {   
        increaseScoreGameEvent.Raise();
    }
}
