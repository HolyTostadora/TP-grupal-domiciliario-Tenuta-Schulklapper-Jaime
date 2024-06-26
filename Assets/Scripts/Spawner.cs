﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public GameObject[] objetos;
    public Transform spawnPoint;
    public float intervaloSpawn;
    private int indiceObjeto;
    public int cantidadDeObjCreados;
    private int contadorDeRepeticiones = 0;
    public Button spawnButton;
    public GameObject Panel_Inicio;
    public GameObject Panel_Rta;
    public List<GameObject> spawneados = new List<GameObject>();
    public 

    void Start()
    {
        Panel_Inicio.SetActive(true);
        Panel_Rta.SetActive(false);
    }

    public void CLICK()
    {
        Panel_Inicio.SetActive(false);
        cantidadDeObjCreados = Random.Range(1, 10);
        indiceObjeto = Random.Range(0, objetos.Length);
        contadorDeRepeticiones = 0;
        Debug.Log(cantidadDeObjCreados);
        spawneados.Clear();
        InvokeRepeating(nameof(spawnObject), 0, 1);
    }

    public void spawnObject()
    {
        if (contadorDeRepeticiones >= cantidadDeObjCreados)
        {
            CancelInvoke("spawnObject");
            Panel_Rta.SetActive(true);
            return;
        }

        GameObject objectToSpawn = objetos[indiceObjeto];
        GameObject spawnedObject = Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);

        spawneados.Add(spawnedObject);

        contadorDeRepeticiones++;
    }
}
