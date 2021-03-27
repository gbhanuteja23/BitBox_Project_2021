using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script for controlling the UI

public class UIController : MonoBehaviour
{
    public GameObject menuUI;

    public GameObject credits;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Function for opening Credits Panel
    public void OpenCredits()
    {
        menuUI.SetActive(false);

        credits.SetActive(true);

    }

    //Function for going back to Main Menu
    public void GoBack()
    {
        credits.SetActive(false);

        menuUI.SetActive(true);

    }

    //Function for quitting the APP
    public void ExitAPP()
    {
        Application.Quit();

    }

}
