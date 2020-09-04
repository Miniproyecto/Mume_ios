using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    int clicks = 0;
    float timer;
    float tiempoclick = 0;
    public AudioClip menu = null;
    bool reproducir = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (reproducir)
        {
            AudioSource.PlayClipAtPoint(menu, new Vector3(0, 0, 0), 1);
            reproducir = false;
        }

        if (timer >= 21)
        {
            reproducir = true;
            timer = 0;
        }


        if (timer >= 5 && clicks ==1 )
        {
            SceneManager.LoadScene("Niveles");
        }

        if(timer >= 5 && clicks == 2)
        {
            SceneManager.LoadScene("Instrucciones");
        }

        if(timer >=5 && clicks == 3){
            SceneManager.LoadScene("ModoPrueba");
        }

        if(timer >= 5 && clicks == 4)
        {
            SceneManager.LoadScene("Proposito");
        }

        if (timer >= 5 && clicks == 5)
        {
            Application.Quit();
        }

        if (Input.GetMouseButtonDown(0)) // este detecta solo una vez cuando se presiona
        {
            timer = 0;
            clicks++;
        }

        if (Input.GetMouseButton(0)) // este detecta cuando se queda oprimido 
        {
            tiempoclick += Time.deltaTime;
            Debug.Log(tiempoclick);


        }

        if (tiempoclick > 3) // si dejo oprimido tres segundo o mas se sale el juego 
        {
            Application.Quit();
        }

    }



    public void clickJugar()
    {
        SceneManager.LoadScene("Niveles");

    }

    public void clickInstrucciones()
    {
        SceneManager.LoadScene("Instrucciones");

    }

    public void clickPrueba()
    {
        SceneManager.LoadScene("Instrucciones");
    }

    public void clickProposito()
    {
        SceneManager.LoadScene("Proposito");

    }

    public void clickSalir()
    {
        Application.Quit();
    }

}
