using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class AcomodarLibros : MonoBehaviour
{
    public GameObject PiezaSeleccionada;
    int capa = 2;
    public int PiezasEncajadas = 0;
    public bool CambiodeEscena = false;
    public bool Noestastocandonada;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.transform.CompareTag("Puzzle"))
            {
                if (!hit.transform.GetComponent<libros>().Encajada)
                {
                    PiezaSeleccionada = hit.transform.gameObject;
                    PiezaSeleccionada.GetComponent<libros>().Seleccionada = true;
                    PiezaSeleccionada.GetComponent<SortingGroup>().sortingOrder = capa;
                    capa++;
                }
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (PiezaSeleccionada != null)
            {
                PiezaSeleccionada.GetComponent<libros>().Seleccionada = false;
                PiezaSeleccionada = null;
            }
        }
        if (PiezaSeleccionada != null)
        {
            Vector3 raton = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            PiezaSeleccionada.transform.position = new Vector3(raton.x, raton.y, 0);
        }

        if (PiezasEncajadas == 3)
        {
            SceneManager.LoadScene("Creditos");
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene("Puzzle libros");
        Time.timeScale = 1;
    }

    public void Exit()
    {
        SceneManager.LoadScene("Living Room");
        Time.timeScale = 1;
    }
}
