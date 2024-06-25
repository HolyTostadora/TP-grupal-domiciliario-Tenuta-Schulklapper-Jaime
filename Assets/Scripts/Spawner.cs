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
    private int contadorDeRepeticiones = 0;


    void Start()
    {
        
        cantidadDeObjCreados = Random.Range(1,10);
        indiceObjeto = Random.Range(0, objetos.Length);
        Debug.Log(cantidadDeObjCreados);
        InvokeRepeating(nameof(spawnObject), 0, 1);
    }

    void spawnObject()
    {
        if (contadorDeRepeticiones >= cantidadDeObjCreados)
        {
            CancelInvoke("spawnObject");
            return;
        }
        GameObject objectToSpawn = objetos[indiceObjeto];
        Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
        contadorDeRepeticiones++;
    }
}

