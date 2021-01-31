using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimonSays : MonoBehaviour
{
    public Image Contador; //VorschauImage

    public GameObject Gamemanager; //NitchDruckenImage

    public List<Color> Colores; //Farben

    public int numerodecolores; //AnzahiFarben
    public int mostrarcolores; //FarbenZeigen

    public int Desaparece; //NotchFehlend
    public Text DesapacererTexto; //NotchFehlendText;

    public List<int> Secuencia; //Reihenfolge

    public Text Leveltext;

    public GameObject EndScene;

    // Start is called before the first frame update
    void Start()
    {
        Secuencia = new List<int>();
        StartCoroutine(Starten());
    }

    // Update is called once per frame
    public void Generator()
    {
        numerodecolores++;

        Leveltext.text = "Level: " + numerodecolores;

        Secuencia.Add(Random.Range(0, 4));

        VistaPrevia();
    }

    public void VistaPrevia()
    {
        if(Secuencia.Count <= mostrarcolores)
        {
            Contador.color = Color.white;
            mostrarcolores = 0;
            Desaparece = Secuencia.Count;
            DesapacererTexto.text = Desaparece.ToString();
            Gamemanager.SetActive(false);
        }
        else
        {
            Contador.color = Colores[Secuencia[mostrarcolores]];

            StartCoroutine(Siguiente());
        }
    }

    public void Botondecolor(int ID)
    {
        if (ID == Secuencia[mostrarcolores])
        {
            mostrarcolores++;
            Desaparece--;
            DesapacererTexto.text = Desaparece.ToString();

            if (mostrarcolores == Secuencia.Count)
            {
                Gamemanager.SetActive(true);
                DesapacererTexto.text = "";
                Desaparece = 0;
                mostrarcolores = 0;
                StartCoroutine(Starten());
            }          
        }
        else
        {
            DesapacererTexto.text = "error";
            Time.timeScale = 0;
        }

    }

    public void Reinicio()
    {
        Secuencia = new List<int>();
        numerodecolores = 0;
        Leveltext.text = "Level" + numerodecolores;
        StartCoroutine(Starten());
    }

    IEnumerator Starten()
    {
        yield return new WaitForSeconds(0.01f);

        Generator();
    }

    IEnumerator Siguiente()
    {
        if (numerodecolores == 8)
        {
            if (VariablesGlobales.Sello_azar == 1)
            {
                VariablesGlobales.Sello = true;
            }
            SceneManager.LoadScene("Library");
        }

        yield return new WaitForSeconds(0.5f);

        Contador.color = Color.white;

        yield return new WaitForSeconds(0.7f);

        mostrarcolores++;

        VistaPrevia();

     

    }

    public void Retry()
    {
        SceneManager.LoadScene("Simon dice");
        Time.timeScale = 1;
    }

    public void Exit()
    {
        SceneManager.LoadScene("Library");
        Time.timeScale = 1;
    }
}
