using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class lvl1 : MonoBehaviour
{
    // Start is called before the first frame update
    float timer = 0;
    float tiempoclick = 0;
    bool activePer1 = true; // bandera para saber si esta activo el personaje1
    bool activePer2 = true; //bandera para saber si esta activo el personaje2
    bool activePer3 = true; //bandera para saber si esta activo el personaje3
    bool activePer4 = true; //bandera para saber si esta activo el personaje4
    

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(activePer1 == false && timer >= 1  ) // si no esta activado y paso 1 seg activa el boton y su imagen
        {
            activePer1 = true;
            GameObject.Find("Personaje1").GetComponent<Image>().enabled = true;
            GameObject.Find("Personaje1").GetComponent<Button>().enabled = true;

        }

        if (activePer2 == false && timer >= 1)// si no esta activado y paso 1 seg activa el boton y su imagen
        {
            activePer2 = true;
            GameObject.Find("Personaje2").GetComponent<Image>().enabled = true;
            GameObject.Find("Personaje2").GetComponent<Button>().enabled = true;

        }

        if (activePer3 == false && timer >= 1)// si no esta activado y paso 1 seg activa el boton y su imagen
        {
            activePer3 = true;
            GameObject.Find("Personaje3").GetComponent<Image>().enabled = true;
            GameObject.Find("Personaje3").GetComponent<Button>().enabled = true;

        }


        if (activePer4 == false && timer >= 1)// si no esta activado y paso 1 seg activa el boton y su imagen
        {
            activePer4 = true;
            GameObject.Find("Personaje4").GetComponent<Image>().enabled = true;
            GameObject.Find("Personaje4").GetComponent<Button>().enabled = true;

        }

        if (tiempoclick >= 3) // si le dejo oprimido 3 seg o mas se regresa al menu
        {
            SceneManager.LoadScene("Menu");
        }


        if (Input.GetMouseButton(0)) // este detecta cuando se queda oprimido 
        {
            tiempoclick += Time.deltaTime;
            Debug.Log(tiempoclick);

        }


    }


    public void Personaje1()
    {
        if( activePer2 && activePer3 && activePer4)
        {
            GameObject.Find("Personaje1").GetComponent<Image>().enabled = false;//desactiva la imagen del boton
            GameObject.Find("Personaje1").GetComponent<Button>().enabled = false;// desactiva el boton
            timer = 0;
            activePer1 = false;
            tiempoclick = 0; // se iguala a 0 para que no se acumule el tiempo que le da click mientras juega 
            Debug.Log("Click en rojo");
        }
        
        
    }


    public void Personaje2()
    {
        if (activePer1 && activePer3 && activePer4) //if para que no pueda presionar mas de un boton al mismo tiempo 
        {
            GameObject.Find("Personaje2").GetComponent<Image>().enabled = false;//desactiva la imagen del boton
            GameObject.Find("Personaje2").GetComponent<Button>().enabled = false; // desactiva el boton
            timer = 0;
            activePer2 = false;
            tiempoclick = 0;
            Debug.Log("Click en verder");
        }

            
    }

    public void Personaje3()
    {
        if (activePer2 && activePer1 && activePer4)//if para que no pueda presionar mas de un boton al mismo tiempo 
        {
            GameObject.Find("Personaje3").GetComponent<Image>().enabled = false; //desactiva la imagen del boton
            GameObject.Find("Personaje3").GetComponent<Button>().enabled = false;// desactiva el boton
            timer = 0;
            activePer3 = false;
            tiempoclick = 0;
            Debug.Log("Click en rosa");
        }

           
    }

    public void Personaje4()//if para que no pueda presionar mas de un boton al mismo tiempo 
    {
        if (activePer2 && activePer3 && activePer1)
        {
            GameObject.Find("Personaje4").GetComponent<Image>().enabled = false;//desactiva la imagen del boton
            GameObject.Find("Personaje4").GetComponent<Button>().enabled = false;// desactiva el boton
            timer = 0;
            activePer4 = false;
            tiempoclick = 0;
            Debug.Log("Click en azul");
        }

            
    }

}
