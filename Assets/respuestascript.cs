using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class respuestascript : MonoBehaviour
{
    // Start is called before the first frame update
    public int respuesta;
    public InputField inputresp;
    public Button Botonrespuesta; 
    public Spawner Spawner;
    public Text texto;
    public Button Buttoncerrar;
    public Button Buttonsalir;
    public Text panelnadaingresadotxt;
    public GameObject panelalgoingresado;
    public GameObject panelnadaingresado;
    public Text buttonsalirtxt;
    public GameObject panelrespuesta;
    public GameObject destrucction;
    

    public void cerrarpanelnada()
    {
        panelnadaingresado.SetActive(false);
    }
    public void cerrarpanelalgo()
    {
        panelrespuesta.SetActive(false);
        panelalgoingresado.SetActive(false);
        Spawner.Panel_Inicio.SetActive(true);
        SceneManager.LoadScene("UI");

    }
    public void OnclickAsButton ()
    {
        
        respuesta = Spawner.cantidadDeObjCreados;
        if (inputresp.text == "")
        {

            panelnadaingresadotxt.text = "Debes ingresar un resultado";
            panelnadaingresado.SetActive(true);

        }
        else
        {
            if(int.Parse(inputresp.text) == respuesta)
            {
                panelrespuesta.SetActive(false);
                texto.text = "Correcto";
                buttonsalirtxt.text = "Reiniciar el desafio";
                panelalgoingresado.SetActive(true);
            }
            else
            {

                texto.text = "Incorrecto"; 
                buttonsalirtxt.text = "intentalo de nuevo";
                panelalgoingresado.SetActive(true);
                Debug.Log("Incorrecto");
                inputresp.text = "";

            }
        }
    }
    void Start()
    {
        panelalgoingresado.SetActive(false);
        panelnadaingresado.SetActive(false);
        panelrespuesta.SetActive(false);
    }

    //public void DestroyObjects()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
