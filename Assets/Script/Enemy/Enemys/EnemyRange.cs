using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRangeA : PlayerCerca
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
            if (!IsInvoking("Disparo"))
            {
                Disparo();
            }
        }
        else 
        {
            CancelInvoke("Disparo");
            Caminar();
        }
    }

    private void Caminar()
    {
        Transform playerp = player.transform;
        Vector3 direccion = (playerp.position - transform.position).normalized;
        float paso = velocidad * Time.deltaTime;
        transform.position += direccion * paso;
    }

    void Disparo()
    {
        if(player != null)
        {
            Instantiate(prefab, gameObject.transform);
            Invoke("Disparo", 2.5f);
        }
    }
}
