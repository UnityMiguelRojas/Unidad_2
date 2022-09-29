using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Declaración de variables
    public GameObject[] animalPrefabs; // Objetos del juego de los prefabs en un array
    private float spawnRangeX = 20;
    private float spawnRangeZ = 20;
    private float startDelay =2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        // Con esta linea de codigo se crean los animales cuando inicia el juego.
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        //Con la letra "S" salen corriendo los animales
        if(Input.GetKeyDown(KeyCode.S))
        {
            //Se usa para que salgan de manera aleatroria
            SpawnRandomAnimal();
        }
        
    }

    void SpawnRandomAnimal()
    {
        //Generar los animales en los limites espcificados del plano de juego
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);

        //Con el array se inidica que salgan todos los animales y no solo uno en especifico.
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
