using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Declaración de variables
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;

    //Declaración de objeto de juego
    public GameObject projectilPrefab;

    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Ubicar lo limites del juegado en el eje negativo de las X
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        
        //Ubicar los limites del jugador en el eje X positivo
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //Cuando el usuario presione la tacle barra espaciadora se generará el objeto "projectilPrefab
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilPrefab, transform.position, projectilPrefab.transform.rotation);
        }

    }
}
