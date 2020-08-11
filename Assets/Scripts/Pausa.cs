using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    // Start is called before the first frame update
    bool active;
    Canvas canvas;

    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            active = !active;
            canvas.enabled = active;
            Time.timeScale = (active) ? 0 : 1; // si active es 1 se pausa si es 0 se quita la pausa
        }

        if(Input.GetKeyDown("backspace") && active)
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("Menu");
        }
        
    }
}
