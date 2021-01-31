using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreadorTrigger : MonoBehaviour
{
    public void OnMouseUpAsButton()
    {
        SceneManager.LoadScene("The Crown");
    }
}
