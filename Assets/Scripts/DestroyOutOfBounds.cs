using System;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [Header("Bounds Settings")]
    [SerializeField] private float XLowerLimit; 


    private void Update()
    {
        if (transform.position.x < XLowerLimit)
        {
            Destroy(gameObject);
        }
    }
}
