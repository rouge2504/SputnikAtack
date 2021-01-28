using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle15 : MonoBehaviour
{
    public CajaNumero cajaPrefab;
    public CajaNumero[,] cajas = new CajaNumero[4, 4];
    public Sprite[] sprites;
    void Start()
    {
        Inicio();
    }

    void Inicio()
    {
        int n = 0;
        for (int y=3;y>=0;y--)
        for (int x = 0; x < 4; x++)
            {
                CajaNumero caja = Instantiate(cajaPrefab, new Vector2(x, y), Quaternion.identity);
                caja.Inicio(x, y, n + 1, sprites[n], hacerCambio);
                cajas[x, y] = caja;
                n++;
            }
    }

    void hacerCambio(int x, int y)
    {
        int dx = getDX(x, y);
        int dy = getDY(x, y);

        var from = cajas[x, y];
        var target = cajas[x + dx, y + dy];

        cajas[x, y] = target;
        cajas[x + dx, y + dy] = from;

        from.ActualizarPos(x + dx, y + dy);
        target.ActualizarPos(x, y);
    }

    int getDX(int x, int y)
    {
        if (x<3 && cajas[x + 1, y].estaVacio())
        {
            return 1;
        }
        if (x > 0 && cajas[x - 1, y].estaVacio())
        {
            return -1;
        }
        return 0;
    }

    int getDY(int x, int y)
    {
        if (y < 3 && cajas[x, y+1].estaVacio())
        {
            return 1;
        }
        if (y > 0 && cajas[x, y-1].estaVacio())
        {
            return -1;
        }
        return 0;
    }
}
