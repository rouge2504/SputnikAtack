using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class PanelTask : MonoBehaviour
{
    public TextMeshProUGUI display;
    public TextMeshProUGUI papel;
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
        if (display.text.Length >= 4)
        {
            return;
        }

        display.text += number;
    }

    public void EraseDisplay()
    {
        display.text = "";
    }

    private void GeneratePasword()
    {
        papel.text = "";

        for (int i = 0; i < 4; i++)
        {
            int randNumber = UnityEngine.Random.Range(1, 6);
            papel.text += randNumber;
        }
    }

    public void CheckPasword()
    {
        if (display.text.Equals(papel.text))
        {
            display.text = "Correct";

            tiempoInicial++;
            if (tiempoInicial == 1)
            {
                SceneManager.LoadScene("Puzzle libros");
            }
        }
        else
        {
            display.text = "Denied";
        }
    }
}
