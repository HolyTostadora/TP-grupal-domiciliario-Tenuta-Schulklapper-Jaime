using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
   
    public GameObject[] objetos; 
    public Transform spawnPoint;
    public float intervaloSpawn;
    private int indiceObjeto;
    private int cantidadDeObjCreados;
    private int contadorDeRepeticiones = 0;
    public Button spawnButton;
    public GameObject Panel_Inicio;

    void Start()
    {
        Panel_Inicio.SetActive(true);
    }

    public void CLICK ()
    {

        Panel_Inicio.SetActive(false); 
        cantidadDeObjCreados = Random.Range(1,10);
        indiceObjeto = Random.Range(0, objetos.Length);
        contadorDeRepeticiones = 0;
        Debug.Log(cantidadDeObjCreados);
        InvokeRepeating(nameof(spawnObject), 3, 1);
    }

    public void spawnObject()
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