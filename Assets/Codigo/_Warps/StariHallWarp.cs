using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StariHallWarp : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<MovimientoJugador>() != null)
        {
            SceneManager.LoadScene("Stair Hall");
        }
    }
}
