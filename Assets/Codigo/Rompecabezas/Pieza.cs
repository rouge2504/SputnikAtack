using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Pieza : MonoBehaviour
{
    private Vector3 PosicionCorreta;
    public bool Encajada;
    public bool Seleccionada;

    // Start is called before the first frame update
    void Start()
    {
        PosicionCorreta = transform.position;
        transform.position = new Vector3(Random.Range(3f, 8f), Random.Range(-3f, 3f));
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, PosicionCorreta) < 0.5F)
        {
            if (!Seleccionada)
            {
                if (Encajada == false)
                {
                    transform.position = PosicionCorreta;
                    GetComponent<SortingGroup>().sortingOrder = 0;
                    Camera.main.GetComponent<juego>().PiezasEncajadas++;
                }
            }
        }
    }
}
