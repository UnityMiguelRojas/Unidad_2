using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    //Declaración de variables 
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {

        int pelota = Random.Range(0, 3);
        //Generar índice de bola aleatorio y posición de generación aleatoria
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instanciar la bola en una ubicación de generación aleatoria
        Instantiate(ballPrefabs[pelota], spawnPos, ballPrefabs[pelota].transform.rotation);

        //El tiempo que salga la pelota sea de manera aleatoria, pudiendo salir entre 1 segundo hasta 4.
        startDelay = Random.Range(1, 5);

        //Uso de recursividad para usar la función dentro de la misma función para que genere la pelotas en distinto tiempo
        Invoke("SpawnRandomBall", startDelay);
    }

}
