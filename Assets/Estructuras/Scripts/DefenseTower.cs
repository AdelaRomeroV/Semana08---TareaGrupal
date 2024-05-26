using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseTower : Estructure_ItemSpawner
{
    [SerializeField] GameObject Bullet;
    [SerializeField] GameObject Target;
    [SerializeField] Transform TowerCenter;
    [SerializeField] float radius;
    [SerializeField] LayerMask EnemyLayer;
    [SerializeField] float ShootVel;

    bool canShoot = true;
 
    void DetectEnemy()
    {
        Collider[] colliders = Physics.OverlapSphere(TowerCenter.position, radius, EnemyLayer);

        if (Target == null && colliders.Length > 0)
        {
            Target = colliders[0].gameObject;
        }
    }

    private void Update()
    {
        DetectEnemy();

        if(Target != null && canShoot)
        {
            StartCoroutine(Spawner(Bullet, TowerCenter));
        }

    }

    public override IEnumerator Spawner(GameObject Item, Transform SpawnCenter)
    {
        canShoot = false;
        GameObject bullet = Instantiate(Bullet, TowerCenter.position, TowerCenter.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        Vector3 dir = new Vector3(Target.transform.position.x - bullet.transform.position.x, Target.transform.position.y - bullet.transform.position.y, Target.transform.position.z - bullet.transform.position.z);
        rb.velocity = dir.normalized * ShootVel * Time.deltaTime * 10;

        yield return new WaitForSeconds(1);
        canShoot = true;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(TowerCenter.position, radius);
    }
}
