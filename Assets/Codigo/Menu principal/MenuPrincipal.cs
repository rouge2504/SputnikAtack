using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Simon dice");
    }

    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void salir()
    {
        Application.Quit();
    }
}
