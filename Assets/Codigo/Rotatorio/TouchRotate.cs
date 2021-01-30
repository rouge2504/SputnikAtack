using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRotate : MonoBehaviour
{
    float[] rotations = { 90, 180, 270 };

    void Start()
    {
        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 0, rotations[rand]);
    }

    public void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (!GameControl.youWin)
        {
            transform.Rotate(0f, 0f, 90f);
        }
    }
}
