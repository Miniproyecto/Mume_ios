using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Linq;

public class lvl1 : MonoBehaviour
{
    // Start is called before the first frame update
    float timer = 0;
    float tiempoclick = 0;
    bool activePer1 = true; // bandera para saber si esta activo el personaje1
    bool activePer2 = true; //bandera para saber si esta activo el personaje2
    bool activePer3 = true; //bandera para saber si esta activo el personaje3
    bool activePer4 = true; //bandera para saber si esta activo el personaje4

    bool agregarlist = true;
    bool reproducir_secuencia = true;
    bool limpiar = false;

    int rand = 0;
    int contador = 0;

    List<int> reproducir = new List<int>();
    List<int> aux = new List<int>();
    List<int> jugador = new List<int>();


    public AudioClip sonido_z = null;
    public AudioClip sonido_x = null;
    public AudioClip sonido_a = null;
    public AudioClip sonido_s = null;


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

        if(agregarlist)
            agregar(); // agregamos un numero random a la lista 


        if(activePer1 && activePer2 && activePer3 && activePer4 && reproducir_secuencia) // si todos los botones estan encendidos podemos proceder a reproducir la lista
        {
            if(timer >= 2) // este timer es para que si salen repetidas de tiempo de que aparezcan y desaparezcan 
            {
                foreach (int i in reproducir) // cada elemento de reproducir se guarda en i
                {
                    Reproducir(i);
                    break;
                }
                contador = 0;
            }
            
        }

  

        





    }


    public void Personaje1()
    {
        if( activePer2 && activePer3 && activePer4 && !reproducir_secuencia)
        {
            GameObject.Find("Personaje1").GetComponent<Image>().enabled = false;//desactiva la imagen del boton
            GameObject.Find("Personaje1").GetComponent<Button>().enabled = false;// desactiva el boton
            timer = 0;
            activePer1 = false;
            tiempoclick = 0; // se iguala a 0 para que no se acumule el tiempo que le da click mientras juega 
            jugador.Add(1);
            Debug.Log("Click en rojo");
            AudioSource.PlayClipAtPoint(sonido_z, new Vector3(0, 0, 0), 1);

            if (reproducir.ElementAt(jugador.Count-1)!=1){ //con esto entramos al elemento de reproducir que en teoria debe de ser 1 
                //el -1 es por que el count te regresa cuantos elementos tiene y como minimo es 1
                Debug.Log("Malll");

            }

            if (jugador.Count == reproducir.Count) // si las listas son iguales se reproduce la secuencia, se limpia la lista del jugador y se añade una nueva
            {
                reproducir_secuencia = true;
                jugador.Clear();
                agregarlist = true;

            }


        }
        
        
    }


    public void Personaje2()
    {
        if (activePer1 && activePer3 && activePer4 && !reproducir_secuencia) //if para que no pueda presionar mas de un boton al mismo tiempo 
        {
            GameObject.Find("Personaje2").GetComponent<Image>().enabled = false;//desactiva la imagen del boton
            GameObject.Find("Personaje2").GetComponent<Button>().enabled = false; // desactiva el boton
            timer = 0;
            activePer2 = false;
            tiempoclick = 0;
            jugador.Add(2);
            Debug.Log("Click en verder");
            AudioSource.PlayClipAtPoint(sonido_x, new Vector3(0, 0, 0), 1);


            if (reproducir.ElementAt(jugador.Count - 1) != 2)
            { //con esto entramos al elemento de reproducir que en teoria debe de ser 1 
                //el -1 es por que el count te regresa cuantos elementos tiene y como minimo es 1
                Debug.Log("Malll");

            }

            if (jugador.Count == reproducir.Count)
            {
                reproducir_secuencia = true;
                jugador.Clear();
                agregarlist = true;

            }
        }

            
    }

    public void Personaje3()
    {
        if (activePer2 && activePer1 && activePer4 && !reproducir_secuencia)//if para que no pueda presionar mas de un boton al mismo tiempo 
        {
            GameObject.Find("Personaje3").GetComponent<Image>().enabled = false; //desactiva la imagen del boton
            GameObject.Find("Personaje3").GetComponent<Button>().enabled = false;// desactiva el boton
            timer = 0;
            activePer3 = false;
            tiempoclick = 0;
            jugador.Add(3);
            Debug.Log("Click en rosa");
            AudioSource.PlayClipAtPoint(sonido_a, new Vector3(0, 0, 0), 1);


            if (reproducir.ElementAt(jugador.Count - 1) != 3)
            { //con esto entramos al elemento de reproducir que en teoria debe de ser 1 
                //el -1 es por que el count te regresa cuantos elementos tiene y como minimo es 1
                Debug.Log("Malll");

            }

            if (jugador.Count == reproducir.Count)
            {
                reproducir_secuencia = true;
                jugador.Clear();
                agregarlist = true;

            }
        }

           
    }

    public void Personaje4()//if para que no pueda presionar mas de un boton al mismo tiempo 
    {
        if (activePer2 && activePer3 && activePer1 && !reproducir_secuencia)
        {
            GameObject.Find("Personaje4").GetComponent<Image>().enabled = false;//desactiva la imagen del boton
            GameObject.Find("Personaje4").GetComponent<Button>().enabled = false;// desactiva el boton
            timer = 0;
            activePer4 = false;
            tiempoclick = 0;
            jugador.Add(4);
            Debug.Log("Click en azul");
            AudioSource.PlayClipAtPoint(sonido_s, new Vector3(0, 0, 0), 1);


            if (reproducir.ElementAt(jugador.Count - 1) != 4)
            { //con esto entramos al elemento de reproducir que en teoria debe de ser 1 
                //el -1 es por que el count te regresa cuantos elementos tiene y como minimo es 1
                Debug.Log("Malll");

            }

            if (jugador.Count == reproducir.Count)
            {
                reproducir_secuencia = true;
                jugador.Clear();
                agregarlist = true;

            }
        }
  
    }


    public void agregar()
    {
        Debug.Log("agregar");
        rand = UnityEngine.Random.Range(1, 5); 
        reproducir.Add(rand);
        agregarlist = false;
        
        //reproducir_secuencia = false;
    }

    public void Reproducir(int n)
    {
        // reproducir_secuencia = false;
        Debug.Log("reproducir");

        if (n == 1)
        {
            GameObject.Find("Personaje1").GetComponent<Image>().enabled = false;//desactiva la imagen del boton
            GameObject.Find("Personaje1").GetComponent<Button>().enabled = false;// desactiva el boton
            timer = 0;
            activePer1 = false;
            AudioSource.PlayClipAtPoint(sonido_z, new Vector3(0, 0, 0), 1);

        }

        if (n == 2)
        {
            GameObject.Find("Personaje2").GetComponent<Image>().enabled = false;//desactiva la imagen del boton
            GameObject.Find("Personaje2").GetComponent<Button>().enabled = false;// desactiva el boton
            timer = 0;
            activePer2 = false;
            AudioSource.PlayClipAtPoint(sonido_x, new Vector3(0, 0, 0), 1);

        }

        if (n == 3)
        {
            GameObject.Find("Personaje3").GetComponent<Image>().enabled = false;//desactiva la imagen del boton
            GameObject.Find("Personaje3").GetComponent<Button>().enabled = false;// desactiva el boton
            timer = 0;
            activePer3 = false;
            AudioSource.PlayClipAtPoint(sonido_a, new Vector3(0, 0, 0), 1);

        }

        if (n == 4)
        {
            GameObject.Find("Personaje4").GetComponent<Image>().enabled = false;//desactiva la imagen del boton
            GameObject.Find("Personaje4").GetComponent<Button>().enabled = false;// desactiva el boton
            timer = 0;
            activePer4 = false;
            AudioSource.PlayClipAtPoint(sonido_s, new Vector3(0, 0, 0), 1);

        }

        aux.Add(reproducir.ElementAt(0)); // pasamos los datos a un auxiliar 
        reproducir.RemoveAt(0); // le quitamos el primer elemento;

        if(reproducir.Count == 0) // si la lista esta vacia ya no reproducimos la secuencia;
        {
             reproducir_secuencia = false;
                foreach (int i in aux) // cuando termina de reproducir vuelve a llenar la lista principal y vacia el aux
                {
                    reproducir.Add(i);
                }
                aux.Clear();
        }

    }

}
