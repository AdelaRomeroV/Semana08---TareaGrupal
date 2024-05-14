using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Movimiento : MonoBehaviour
{
    [SerializeField] protected float speed;
    protected Rigidbody rb;

    private void Awake()
    {
        Initialize();
    }

    protected virtual void Initialize()
    {
        rb = GetComponent<Rigidbody>();
    }
        
    void Update()
    {
        Move();
    }

    protected virtual void Move()
    {

    }   
}
