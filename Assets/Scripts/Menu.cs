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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        

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
