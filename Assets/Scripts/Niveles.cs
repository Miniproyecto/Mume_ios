﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Niveles : MonoBehaviour
{
    float timer = 0;
    float tiempoclick = 0;
    int clicks = 0;
    public AudioClip audioniveles = null;
    bool reproducirniveles = true;
    public AudioClip audiofacil = null;
    bool reproducirfacil = true;
    public AudioClip audiomedio = null;
    bool reproducirmedio = true;
    public AudioClip audiodificil = null;
    bool reproducirdificil = true;
    private AudioSource instrucciones;


    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (reproducirniveles)
        {
            AudioSource.PlayClipAtPoint(audioniveles, new Vector3(0, 0, 0), 1);
            reproducirniveles = false;
        }

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

        if (timer >= 10 && clicks == 1 && reproducirfacil)
        {
            reproducirfacil = false;
            AudioSource.PlayClipAtPoint(audiofacil, new Vector3(0, 0, 0), 1);
        }
        if (timer >= 12 && clicks == 1 && !reproducirfacil)
        {
            SceneManager.LoadScene("SampleScene");
        }

        if(timer >= 10 && clicks == 2 && reproducirmedio )
        {
            reproducirmedio = false;
            AudioSource.PlayClipAtPoint(audiomedio, new Vector3(0, 0, 0), 1);
        }

        if (timer >= 12 && clicks == 2 && !reproducirmedio)
        {
            SceneManager.LoadScene("lvl2");
        }

        if (timer >= 10 && clicks == 3 && reproducirdificil )
        {
            reproducirdificil = false;
            AudioSource.PlayClipAtPoint(audiodificil, new Vector3(0, 0, 0), 1);
        }

        if (timer >= 12 && clicks == 3 &&  !reproducirdificil)
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
