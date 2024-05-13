using System.Collections;
using UnityEngine;

public class Estructure_ItemSpawner : MonoBehaviour
{
    public virtual IEnumerator Spawner(GameObject Item, Transform SpawnCenter)
    {
        float x = Random.Range(-5, 5);
        float z = Random.Range(-5, 5);

        if(x > -0.5f && x < 0.5f || z > -0.5f && z < 0.5f)
        {
            StartCoroutine(Spawner(Item, SpawnCenter));
            yield break;
        }

        Vector3 spawnPoint = new Vector3(SpawnCenter.position.x + x, SpawnCenter.position.y, SpawnCenter.position.z + z);

        GameObject spawnedItem = Instantiate(Item, spawnPoint, SpawnCenter.rotation);
        spawnedItem.transform.SetParent(transform);

        yield return new WaitForSeconds(2);
        StartCoroutine(Spawner(Item, SpawnCenter));
    }
}
