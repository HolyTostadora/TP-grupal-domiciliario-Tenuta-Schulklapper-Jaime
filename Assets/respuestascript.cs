using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

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
    
    public void cerrarpanelnada()
    {
        panelnadaingresado.SetActive(false);
    }
    public void cerrarpanelalgo()
    {
        panelalgoingresado.SetActive(false);

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
                texto.text = "Correcto";
                buttonsalirtxt.text = "Reiniciar el desafio";
                panelalgoingresado.SetActive(true);
            }
            else
            {
                texto.text = "Incorrecto"; 
                buttonsalirtxt.text = "intentalo de nuevo";
                panelalgoingresado.SetActive(true);
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
