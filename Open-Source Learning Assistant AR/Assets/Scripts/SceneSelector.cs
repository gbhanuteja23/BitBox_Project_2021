using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

//Script for Selecting various Scenes in APP 

public class SceneSelector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Function for starting the APP
    public void StartAPP()
    {
        SceneManager.LoadScene(1);

    }

    //Function for going back to Main Menu Scene 
    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0); 

    }

}
