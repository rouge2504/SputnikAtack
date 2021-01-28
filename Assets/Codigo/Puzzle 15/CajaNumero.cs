using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaNumero : MonoBehaviour
{
    public int index = 0;
    int x = 0;
    int y = 0;
    private Action<int, int> Cambiar= null;

    public void Inicio (int i, int j,int index, Sprite sprite, Action<int,int> Cambiar)
    {
        this.index = index;
        this.GetComponent<SpriteRenderer>().sprite = sprite;
        ActualizarPos(i, j);
        this.Cambiar = Cambiar;
    }

    public void ActualizarPos (int i, int j)
    {
        x = i;
        y = j;
        this.gameObject.transform.localPosition = new Vector2(i, j);
    }

    public bool estaVacio()
    {
        return index == 16;
    }

    public void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Cambiar(x, y);
        }
    }
}
