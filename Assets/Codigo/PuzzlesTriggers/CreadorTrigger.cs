using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreadorTrigger : MonoBehaviour
{
    public void OnMouseUpAsButton()
    {
        if(VariablesGlobales.Cuero == true && VariablesGlobales.Sello == true && VariablesGlobales.Corona == true)
        {
            SceneManager.LoadScene("The Crown");
        }
        
    }
}
