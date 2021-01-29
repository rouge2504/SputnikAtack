using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{

    [SerializeField]
    private Transform[] pictures;


    public static bool youWin;

    
    // Start is called before the first frame update
    void Start()
    {
        youWin = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (pictures[0].transform.rotation.z == 0)
        {
            youWin = true;
            SceneManager.LoadScene("Simon dice");
        }
 

    }

}
