using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedroomLogic : MonoBehaviour
{
    public GameObject enemigo;
    public GameObject luz1;
    public GameObject llave;
    void Start()
    {
        if (VariablesGlobales.Enemigo_fase1_existe == false && VariablesGlobales.Vida_enemigo_fase1 == 100f)
        {
            enemigo.SetActive(true);
            VariablesGlobales.Enemigo_fase1_existe = true;
        }
        else enemigo.SetActive(false);
    }


    void Update()
    {
        if (VariablesGlobales.Enemigo_fase1_existe == true)
        {
            luz1.SetActive(false);
            llave.SetActive(false);
        } else if (VariablesGlobales.Enemigo_fase1_existe == false)
        {
            luz1.SetActive(true);
            if (VariablesGlobales.Llave1 == false)
            {
                llave.SetActive(true);
            }
            else
            {
                llave.SetActive(false);
            }
            
        }
    }
}
