using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculosIniciales : MonoBehaviour
{
    public void Awake()
    {
        
    }

    public void Start()
    {
        objetos_reiniciar();
        vidas_reiniciar();
        zonas_reiniciar();
        RNG_recalcular();
        Debug.Log("Cuero" + VariablesGlobales.Cuero);
        Debug.Log("Sello" + VariablesGlobales.Sello);
        Debug.Log("Corona" + VariablesGlobales.Corona);
    }

    public void objetos_reiniciar()
    {
        VariablesGlobales.Cuero = false;
        VariablesGlobales.Sello = false;
        VariablesGlobales.Corona = false;
        VariablesGlobales.Talisman = false;
    }

    public void vidas_reiniciar()
    {
        VariablesGlobales.Vida_jugador = 100f;
        VariablesGlobales.Vida_enemigo_fase1 = 100f;
        VariablesGlobales.Vida_enemigo_fase2 = 100f;
        VariablesGlobales.Vida_enemigo_fase3 = 100f;
    }

    public void zonas_reiniciar()
    {
        VariablesGlobales.Zona1_bloqueada = true;
        VariablesGlobales.Zona2_bloqueada = false;
    }

    public void RNG_recalcular()
    {
        Cuero_calcular();
        Sello_calcular();
        Corona_calcular();
    }

    public void Cuero_calcular()
    {
        VariablesGlobales.Cuero_azar = Random.Range(1, 5);
    }

    public void Sello_calcular()
    {
        VariablesGlobales.Sello_azar = Random.Range(1, 3);
    }

    public void Corona_calcular()
    {
        VariablesGlobales.Corona_azar = Random.Range(1, 3);
    }
}
