using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PlayerCerca : MonoBehaviour
{
    protected GameObject player;
    protected float radioDeDeteccion = 5f;
    protected bool jugadorDentro = false;

    [SerializeField] protected GameObject prefab;
    [SerializeField] protected GameObject prefabSpawn;
    [SerializeField] protected LayerMask queEsJugador;

    void Awake()
    {
        Inicializar();
    }

    protected virtual void Inicializar()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        Detectar();
    }

    protected virtual void Detectar()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radioDeDeteccion, queEsJugador);
        jugadorDentro = false;
        foreach (Collider collider in colliders)
        {
            if (collider.gameObject.CompareTag("Player"))
            {
                jugadorDentro = true;
            }
        }
    }

    void OnDestroy()
    {
        if (prefabSpawn != null)
        {
            Instantiate(prefabSpawn);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radioDeDeteccion);
    }
}
