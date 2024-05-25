using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : Life
{ 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            ChangeLife(-other.gameObject.gameObject.GetComponent<Damage>().GetDamage());
            Destroy(other.gameObject);

            GetComponent<EnemysDrop>().DropItem();
        }

    }
}
