using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Rotatorio : MonoBehaviour
{
    [SerializeField]
    private Transform Imagen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Imagen.transform.rotation.z == 1)
        {
            GetComponent<SortingGroup>().sortingOrder = -2;
        }
        if (Imagen.transform.rotation.z == -1)
        {
            GetComponent<SortingGroup>().sortingOrder = -2;
        }
    }
}
