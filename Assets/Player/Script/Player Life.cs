using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : Life
{

    private void Update()
    {
        if (life >= 20)
        {
            life = 20;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BulletEnemy"))
        {
            ChangeLife(-other.gameObject.gameObject.GetComponent<Damage>().GetDamage());
            Destroy(other.gameObject);
        }

    }
}
