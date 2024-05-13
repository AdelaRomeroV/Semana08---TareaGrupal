using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRangeB : PlayerCerca
{
    public float velocidad = 5f;

    protected override void Inicializar()
    {
        base.Inicializar();
    }
    protected override void Detectar()
    {
        base.Detectar();
        if (jugadorDentro)
        {
            Caminar();
        }
        else
        {
            if (!IsInvoking("Disparo"))
            {
                Disparo();
            }
        }
    }

    private void Caminar()
    {
        Transform playerTransform = player.transform;
        Vector3 direccion = (playerTransform.position - transform.position).normalized;
        float paso = velocidad * Time.deltaTime;
        transform.position -= direccion * paso;
    }

    void Disparo()
    {
        if (player != null)
        {
            Instantiate(prefab, gameObject.transform);
            Invoke("Disparo", 2.5f);
        }
    }
}
