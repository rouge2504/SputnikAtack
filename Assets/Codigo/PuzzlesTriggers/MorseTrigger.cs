using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MorseTrigger : MonoBehaviour
{
    public void OnMouseUpAsButton()
    {
        SceneManager.LoadScene("Morse");
    }
}
