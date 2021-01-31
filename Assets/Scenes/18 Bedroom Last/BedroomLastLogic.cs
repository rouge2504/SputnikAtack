using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedroomLastLogic : MonoBehaviour
{
    public GameObject luz1;
    public GameObject enemigo;
    void Start()
    {

        if (VariablesGlobales.Enemigo_fase3_existe == false && VariablesGlobales.Vida_enemigo_fase3 == 100f && VariablesGlobales.Talisman == true)
        {
            enemigo.SetActive(true);
            VariablesGlobales.Enemigo_fase3_existe = true;
        }
        else enemigo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (VariablesGlobales.Enemigo_fase3_existe == true)
        {
            luz1.SetActive(false);
        }

        if (VariablesGlobales.Enemigo_fase3_existe == false && VariablesGlobales.Vida_enemigo_fase3 == 0)
        {

        }
    }
}
