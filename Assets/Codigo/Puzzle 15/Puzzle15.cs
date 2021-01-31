using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puzzle15 : MonoBehaviour
{
    public CajaNumero cajaPrefab;
    public CajaNumero[,] cajas = new CajaNumero[4, 4];
    public Sprite[] sprites;
    void Start()
    {
        Inicio();
        for (int i=0; i<999;i++)
        Shuffle();
    }

    void Inicio()
    {
        int n = 0;
        for (int y=3;y>=0;y--)
        for (int x = 0; x < 4; x++)
            {
                CajaNumero caja = Instantiate(cajaPrefab, new Vector2(x, y), Quaternion.identity);
                caja.Inicio(x, y, n + 1, sprites[n], CambiarClick);
                caja.name = "caja " +n;
                cajas[x, y] = caja;
                n++;
            }
    }

    void CambiarClick(int x, int y)
    {
        int dx = getDX(x, y);
        int dy = getDY(x, y);
        Cambiar(x, y, dx, dy);
        if (Victoria())
        {
            if(VariablesGlobales.Corona_azar == 2)
            {
                VariablesGlobales.Corona = true;
            }
            Exit();
        }
    }

    void Cambiar(int x, int y, int dx, int dy)
    {       
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

    void Shuffle()
    {
        for (int i=0; i<4; i++)
        {
            for (int j=0; j<4; j++)
            {
                if (cajas[i, j].estaVacio())
                {
                    Vector2 pos = movValido(i, j);
                    Cambiar(i, j, (int)pos.x,(int)pos.y);
                }
            }
        }
    }

    Vector2 movValido(int x, int y)
    {
        Vector2 pos = new Vector2();
        do
        {
            int n = Random.Range(0, 4);
            if (n == 0)
                pos = Vector2.left;
            else if (n == 1)
                pos = Vector2.right;
            else if (n == 2)
                pos = Vector2.up;
            else if (n == 3)
                pos = Vector2.down;
        }while(!(rangoValido(x + (int)pos.x) && rangoValido(y + (int)pos.y)) || repetido(pos));
        lastMove = pos;
        return pos;
    }

    private Vector2 lastMove;

    bool rangoValido (int n)
    {
        return n >= 0 && n <= 3;
    }

    bool repetido (Vector2 pos)
    {
        return pos * -1 == lastMove;
    }

    bool Victoria()
    {
        int n = 0;
        for (int y = 3; y >= 0; y--)
            for (int x = 0; x < 4; x++)
            {
                if (cajas[x, y].gameObject.name != "caja " + n)
                {
                    return false;
                }
                n++;
            }
        return true;
    }

    public void Retry()
    {
        SceneManager.LoadScene("Puzzle15");
    }

    public void Exit()
    {
        SceneManager.LoadScene("Bathroom");
    }
}
