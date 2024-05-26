using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cash : Item
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DineroPlayer dineroPlayer = other.gameObject.GetComponent<DineroPlayer>();
            if (dineroPlayer != null)
            {
                dineroPlayer.dinerito += count;
                Destroy(gameObject);
            }
        }
    }
}
