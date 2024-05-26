using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : Item
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerArma playerArma = other.gameObject.GetComponent<PlayerArma>();
            if (playerArma != null)
            {
                playerArma.SumarBalas(count);
                Destroy(gameObject);
            }
        }
    }
}
