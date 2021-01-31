using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairHallLogic : MonoBehaviour
{
    public GameObject luz1, luz2, luz3, luz4;
    public GameObject enemigo;
    public GameObject llave;

    public void Start()
    {
        if (VariablesGlobales.Enemigo_fase2_existe == false && VariablesGlobales.Vida_enemigo_fase2 == 100f && VariablesGlobales.Cuero == true && VariablesGlobales.Sello == true)
        {
            enemigo.SetActive(true);
            VariablesGlobales.Enemigo_fase2_existe = true;
        }
        else enemigo.SetActive(false);
    }


    public void Update()
    {
        if (VariablesGlobales.Llave1 == false)
        {
            luz2.SetActive(false);
            luz3.SetActive(false);
        }

        if (VariablesGlobales.Llave2 == false)
        {
            luz1.SetActive(false);
        }
        else if (VariablesGlobales.Llave2 == true)
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

        if (VariablesGlobales.Enemigo_fase2_existe == false && VariablesGlobales.Vida_enemigo_fase2 == 0)
        {
            if (VariablesGlobales.Llave2 == false)
            {
                llave.SetActive(true);
            }
            else
            {
                llave.SetActive(false);
            }

        }
        else llave.SetActive(false);





    }

}
