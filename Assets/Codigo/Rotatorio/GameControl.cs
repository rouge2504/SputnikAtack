using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{

    [SerializeField]
    private Transform[] pictures;

    public bool Imagen0Funciona;
    public bool Imagen1Funciona;
    public bool Imagen2Funciona;
    public bool Imagen3Funciona;
    public bool Imagen4Funciona;
    public bool Imagen5Funciona;

    public static bool youWin;

    
    // Start is called before the first frame update
    void Start()
    {
        youWin = false;
    }

    // Update is called once per frame
    void Update()
    {
        //imagen 0
        if (pictures[0].transform.rotation.z == 1)
        {
            Imagen0Funciona = true;
        }
        if (pictures[0].transform.rotation.z == -1)
        {
            Imagen0Funciona = true;
        }

        //imagen 1
        if(pictures[1].transform.rotation.z == 1)
        {
            Imagen1Funciona = true;
        }
        if (pictures[1].transform.rotation.z == -1)
        {
            Imagen1Funciona = true;
        }

        //imagen 2
        if (pictures[2].transform.rotation.z == 1)
        {
            Imagen2Funciona = true;
        }
        if (pictures[2].transform.rotation.z == -1)
        {
            Imagen2Funciona = true;
        }

        //imagen 3
        if (pictures[3].transform.rotation.z == 1)
        {
            Imagen3Funciona = true;
        }
        if (pictures[3].transform.rotation.z == -1)
        {
            Imagen3Funciona = true;
        }

        //imagen 4
        if (pictures[4].transform.rotation.z == 1)
        {
            Imagen4Funciona = true;
        }
        if (pictures[4].transform.rotation.z == -1)
        {
            Imagen4Funciona = true;
        }

        //imagen 5
        if (pictures[5].transform.rotation.z == 1)
        {
            Imagen5Funciona = true;
        }
        if (pictures[5].transform.rotation.z == -1)
        {
            Imagen5Funciona = true;
        }

        //Victoria

        if (Imagen0Funciona == true && Imagen1Funciona == true && Imagen2Funciona == true && Imagen3Funciona == true && Imagen4Funciona == true && Imagen5Funciona == true)
        {
            youWin = true;
            SceneManager.LoadScene("Cereal Puzzle");
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene("Rotatorio Cocina");
    }

    public void Exit()
    {
        SceneManager.LoadScene("Living Room");
    }

}
