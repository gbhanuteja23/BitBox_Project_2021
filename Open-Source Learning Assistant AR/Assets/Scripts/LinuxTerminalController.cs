using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script which controls all the functionalities in Scene 1 - Terminal Learning
//It controls when to play a video showing how to use the command on the basis of Input from user

public class LinuxTerminalController : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        Terminal.ClearScreen();   //Clears all the contents on the terminal 

        ShowCommandsAvailable(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Function to display the various commands from which user can learn 
    public void ShowCommandsAvailable()
    {
        Terminal.WriteLine("Welcome to Open-Source Learning Assistant! ");
        Terminal.WriteLine("Which command do you want to learn about: ");
        Terminal.WriteLine("\n");

        Terminal.WriteLine("1. cat    2. cat less    3.alias");
        Terminal.WriteLine("");
        Terminal.WriteLine("4. echo   5. ls          5. cd ");
        Terminal.WriteLine("");
        Terminal.WriteLine("7. mkdir   ");


    }

    void OnUserInput(string input)
    {
        if(input == "clear" || input == "cls")
        {
            Terminal.ClearScreen(); 
        }
    }


}
