using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SittingRoomWarp : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<MovimientoJugador>() != null && VariablesGlobales.Enemigo_fase1_existe == false)
        {
            SceneManager.LoadScene("Sitting Room");
        }
    }
}
