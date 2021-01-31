using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairHallLogic : MonoBehaviour
{
    public GameObject luz1, luz2, luz3, luz4;


    public void Update()
    {
        if(VariablesGlobales.Llave1 == false)
        {
            luz2.SetActive(false);
            luz3.SetActive(false);
        }

        if (VariablesGlobales.Llave2 == false)
        {
            luz1.SetActive(false);
        } else if (VariablesGlobales.Llave2 == true)
        {
            luz1.SetActive(true);
        }

        if (VariablesGlobales.Enemigo_fase2_existe == true)
        {
            luz1.SetActive(false);
            luz2.SetActive(false);
            luz3.SetActive(false);
            luz4.SetActive(false);
        }
    }

 

   



}
