using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class god3 : MonoBehaviour
{
    public float tiempoInicial;
    public float TiempoLimite;


    // Update is called once per frame
    void Update()
    {
        tiempoInicial += Time.deltaTime;
        if (tiempoInicial >= TiempoLimite)
        {
            SceneManager.LoadScene("Menu de inicio");
        }
    }
}