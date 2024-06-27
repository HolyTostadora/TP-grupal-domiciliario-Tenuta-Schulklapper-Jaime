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
    public Text cerrartxt;
    private bool correcto_incorrecto;
    

    public void cerrarpanelnada()
    {
        panelnadaingresado.SetActive(false);
        panelrespuesta.SetActive(true);
        texto.text = "";
    }
    public void cerrarpanelalgo()
    {
        if (correcto_incorrecto == true)
        {
            panelalgoingresado.SetActive(false);
            Spawner.Panel_Inicio.SetActive(true);
            foreach (GameObject clon in Spawner.spawneados)
            {
                Destroy(clon);
            }
        }
        else
        {
            texto.text = "";
            panelrespuesta.SetActive(true);
        }
    }
    public void OnclickAsButton ()
    {
        panelrespuesta.SetActive(false);
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
                correcto_incorrecto = true;
            }
            else
            {
                panelrespuesta.SetActive(false);
                texto.text = "Incorrecto"; 
                cerrartxt.text = "intentalo de nuevo";
                panelalgoingresado.SetActive(true);
                inputresp.text = "";
                correcto_incorrecto = false;

            }
        }
    }

    void salir_juego()
    {
        SceneManager.LoadScene("SeleccionarJuegos");
    }
    void Start()
    {
        panelalgoingresado.SetActive(false);
        panelnadaingresado.SetActive(false);
        panelrespuesta.SetActive(false);
    }

}
