using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LivingRoomWarp : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<MovimientoJugador>() != null && VariablesGlobales.Enemigo_fase2_existe == false)
        {
            SceneManager.LoadScene("Living Room");
        }
    }
}
