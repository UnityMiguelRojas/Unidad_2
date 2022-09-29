using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    //Declaración de variables
    public GameObject dogPrefab;
    private float tiempo= 1;
    private float otroDis = 0;

    // Update is called once per frame
    void Update()
    {
        // Cuando precione la barra espaciadora saldrá un perro, y además tendra que esperar 1 segundo 
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > otroDis)
        {
            //Hacemos uso de una bandera para poder hacer que el usuario no lance muchos perros a la vez
            otroDis = Time.time+tiempo;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
