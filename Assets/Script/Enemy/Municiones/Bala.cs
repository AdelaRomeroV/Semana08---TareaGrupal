using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidad = 5f;
    private Transform player;
    private Rigidbody rb;


    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
        Direccion();
        Invoke("Destruir", 5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Destruir();
        }
    }

    private void Direccion()
    {
        Vector3 dir = player.position - transform.position;
        Vector3 movimiento = dir.normalized * velocidad;
        rb.AddForce(movimiento, ForceMode.VelocityChange);
    }

    void Destruir() { Destroy(gameObject); }
}
