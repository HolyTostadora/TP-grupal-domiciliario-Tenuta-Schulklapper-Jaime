using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   
    public GameObject[] objetos; 
    public Transform spawnPoint;
    public float intervaloSpawn;
    private int indiceObjeto;
    private int cantidadDeObjCreados;

    void Start()
    {
        cantidadDeObjCreados = Random.Range(1,10);
        indiceObjeto = Random.Range(0, objetos.Length);
        Debug.Log(cantidadDeObjCreados);
        for (int i = 0; i < cantidadDeObjCreados; i++)
        {
            spawnObject();
        }
    }

    void spawnObject()
    {
        GameObject objectToSpawn = objetos[indiceObjeto];
        Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
    }
}

