using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LibraryWarp : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<MovimientoJugador>() != null && VariablesGlobales.Llave1 == true && VariablesGlobales.Enemigo_fase2_existe == false)
        {
            SceneManager.LoadScene("Library");
        }
    }
}
