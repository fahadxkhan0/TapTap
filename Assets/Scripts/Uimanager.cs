using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Uimanager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void Reset(){
        SceneManager.LoadScene("Level1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
