using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class MoveSistem : MonoBehaviour
{
    public GameObject PiezaSeleccionada;
    int capa = 2;
    public int PiezasEncajadas = 0;
    public bool CambiodeEscena = false;
    public bool ObjetoClave;

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
                if (!hit.transform.GetComponent<Objetos>().Encajada)
                {
                    PiezaSeleccionada = hit.transform.gameObject;
                    PiezaSeleccionada.GetComponent<Objetos>().Seleccionada = true;
                    PiezaSeleccionada.GetComponent<Objetos>().cambiar = + 1;
                    PiezaSeleccionada.GetComponent<SortingGroup>().sortingOrder = capa;
                    capa++;
                }
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (PiezaSeleccionada != null)
            {
                PiezaSeleccionada.GetComponent<Objetos>().Seleccionada = false;
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
            if(VariablesGlobales.Cuero_azar == 3)
            {
                VariablesGlobales.Cuero = true;
            }
            Exit();
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene("Cereal Puzzle");
        Time.timeScale = 1;
    }

    public void Exit()
    {
        SceneManager.LoadScene("Storage");
        Time.timeScale = 1;
    }
}
