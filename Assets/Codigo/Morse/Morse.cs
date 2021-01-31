using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Morse : MonoBehaviour
{
    public TextMeshProUGUI display;
    public TextMeshProUGUI papel;
    public TextMeshProUGUI pantalla;
    public float tiempoInicial;

    // Start is called before the first frame update
    void Start()
    {
        GeneratePasword();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddNumber(string number)
    {
        if (display.text.Length >= 5)
        {
            return;
        }

        display.text += number;
    }

    public void EraseDisplay()
    {
        display.text = "";
        pantalla.text = "";
    }

    private void GeneratePasword()
    {
        papel.text = "12345";
    }

    public void CheckPasword()
    {
        if (display.text.Equals(papel.text))
        {
            pantalla.text = "Correct";

            tiempoInicial++;
            if (tiempoInicial == 1)
            {
                SceneManager.LoadScene("Living Room");
            }
        }
        else
        {
            pantalla.text = "Incorrect";
        }
    }

    public void Exit()
    {
        SceneManager.LoadScene("Living Room");
    }
}
