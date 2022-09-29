using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -35;
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Destruir perros si la posición x es inferior al límite izquierdo
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }
        // Destruye las bolas si la posición y es menor que bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }

    }
}
