using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimonDiceTrigger : MonoBehaviour
{
    public void OnMouseUpAsButton()
    {
        SceneManager.LoadScene("Simon dice");
    }
}
