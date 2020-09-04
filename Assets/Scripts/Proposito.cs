using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Proposito : MonoBehaviour
{
    public AudioClip proposito = null;
    float tiempoclick = 0;
    float timer = 0;
    bool reproducir = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

        if(reproducir)
        {
            AudioSource.PlayClipAtPoint(proposito, new Vector3(0, 0, 0), 1);
            reproducir = false;
        }

        if(timer >= 16)
        {
            reproducir = true;
            timer = 0;
        }

        if (Input.GetMouseButton(0)) // este detecta cuando se queda oprimido 
        {
            tiempoclick += Time.deltaTime;
            Debug.Log(tiempoclick);

        }

        if (tiempoclick >= 3) // si le dejo oprimido 3 seg o mas se regresa al menu
        {
            SceneManager.LoadScene("Menu");
        }
    }

    public void RegresarBtn()
    {
        SceneManager.LoadScene("Menu");

    }

}
