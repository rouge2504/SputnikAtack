using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class libros : MonoBehaviour
{
    private Vector3 PosicionCorreta;
    public bool Encajada;
    public bool Seleccionada;
    public bool Ensulugar;

    public int cambiar = 0;

    // Start is called before the first frame update
    void Start()
    {
        PosicionCorreta = transform.position;
        transform.position = new Vector3(Random.Range(-3f, 3f), Random.Range(-3f, -2f));
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

                    if (transform.position == PosicionCorreta)
                    {
                        Encajada = true;

                        if (Encajada == true)
                        {
                            Camera.main.GetComponent<AcomodarLibros>().PiezasEncajadas++;

                        }
                    }

                }

            }


        }
    }


}
