using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LibrosTrigger : MonoBehaviour
{
    public void OnMouseUpAsButton()
    {
        SceneManager.LoadScene("Puzzle libros");
    }
}
