using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Niveles : MonoBehaviour
{
    float timer = 0;
    float tiempoclick = 0;
    int clicks = 0;

    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetMouseButtonDown(0)) // este detecta cuando se presiona el click
        {
            clicks++;
            timer = 0;
        }

        if (Input.GetMouseButton(0)) // este detecta cuando se queda oprimido 
        {
            tiempoclick += Time.deltaTime;
            Debug.Log(tiempoclick);

        }


        if(tiempoclick >= 3) // si le dejo oprimido 3 seg o mas se regresa al menu
        {
            SceneManager.LoadScene("Menu");
        }

        if (timer >= 4 && clicks == 1)
        {
            SceneManager.LoadScene("SampleScene");
        }

        if (timer >= 4 && clicks == 2)
        {
            SceneManager.LoadScene("lvl2");
        }

        if (timer >= 4 && clicks == 3)
        {
            SceneManager.LoadScene("lvl3");
        }

        if(clicks >= 4)
        {
            clicks = 0;
        }

    }

    public void clickFacil()
    {
        SceneManager.LoadScene("SampleScene");
    }


    public void clickNormal()
    {
        SceneManager.LoadScene("lvl2");
    }

    public void clickRegresar()
    {
        SceneManager.LoadScene("Menu");
    }

    public void clickDificil()
    {
        SceneManager.LoadScene("lvl3");
    }


}
