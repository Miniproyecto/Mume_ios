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

    }
}
