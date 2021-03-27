using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI; 

public class LinuxVideoController : MonoBehaviour
{
    public GameObject Terminalscreen; 

    public GameObject[] LinuxVideoPlayer;    //Array of GameObject storing all the videos of respective commands

    public VideoPlayer[] linuxVideos; 

    LinuxTerminalController linuxController;

    public static string input;   //Input from user

    
    [Space]
    public Text inputField;

    private TouchScreenKeyboard keyboard; 

    // Start is called before the first frame update
    void Start()
    {
        linuxController = GetComponent<LinuxTerminalController>(); 

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(TouchScreenKeyboard.visible == false  && keyboard != null)
        {
            if(keyboard.status)
            input = keyboard.text; 
        }
        */

        input = keyboard.text;

        //Function for ANDROID Build, use the below line only when building for Android
        CheckUserInput();    //Checks the user input        

    }


    ///Code from line 60 to 140 is only when testing the APP inside Unity
    ///or for building it for Windows

    ///Code from line 146 to 220 is only when building this APP for Android
    
    /*

    //This function gets called when user inputs anything on Terminal
    void OnUserInput(string input1)
    {
        //input1 = input;    //Only for android build where input is from touch or else for windows comment it out 

        if (input1 == "cat")
        {
            Terminalscreen.SetActive(false);

            if (!linuxVideos[0].isPlaying)
                linuxVideos[0].Play();

            LinuxVideoPlayer[0].SetActive(true);
        }

        else if (input1 == "cat less")
        {
            Terminalscreen.SetActive(false);

            if (!linuxVideos[1].isPlaying)
                linuxVideos[1].Play();

            LinuxVideoPlayer[1].SetActive(true);
        }

        else if (input1 == "alias")
        {
            Terminalscreen.SetActive(false);

            if (!linuxVideos[2].isPlaying)
                linuxVideos[2].Play();

            LinuxVideoPlayer[2].SetActive(true);
        }

        else if (input1 == "echo")
        {
            Terminalscreen.SetActive(false);

            if (!linuxVideos[3].isPlaying)
                linuxVideos[3].Play();

            LinuxVideoPlayer[3].SetActive(true);
        }

        else if (input1 == "ls")
        {
            Terminalscreen.SetActive(false);

            if (!linuxVideos[4].isPlaying)
                linuxVideos[4].Play();

            LinuxVideoPlayer[4].SetActive(true);
        }

        else if (input1 == "cd")
        {
            Terminalscreen.SetActive(false);

            if (!linuxVideos[5].isPlaying)
                linuxVideos[5].Play();

            LinuxVideoPlayer[5].SetActive(true);
        }

        else if (input1 == "mkdir")
        {
            Terminalscreen.SetActive(false);

            if (!linuxVideos[6].isPlaying)
                linuxVideos[6].Play();

            LinuxVideoPlayer[6].SetActive(true);
        }

        else
        {
            Terminal.WriteLine("\n Invalid Command Entered!");

            //Terminal.ClearScreen();

            linuxController.ShowCommandsAvailable();
        }

        */
    


    //Function doing the same task that is done above but for ANDROID
    
    public void CheckUserInput()
    {
        if (input == "cat")
        {
            Terminalscreen.SetActive(false);

            if (!linuxVideos[0].isPlaying)
                linuxVideos[0].Play();

            LinuxVideoPlayer[0].SetActive(true);
        }

        else if (input == "cat less")
        {
            Terminalscreen.SetActive(false);

            if (!linuxVideos[1].isPlaying)
                linuxVideos[1].Play();

            LinuxVideoPlayer[1].SetActive(true);
        }

        else if (input == "alias")
        {
            Terminalscreen.SetActive(false);

            if (!linuxVideos[2].isPlaying)
                linuxVideos[2].Play();

            LinuxVideoPlayer[2].SetActive(true);
        }

        else if (input == "echo")
        {
            Terminalscreen.SetActive(false);

            if (!linuxVideos[3].isPlaying)
                linuxVideos[3].Play();

            LinuxVideoPlayer[3].SetActive(true);
        }

        else if (input == "ls")
        {
            Terminalscreen.SetActive(false);

            if (!linuxVideos[4].isPlaying)
                linuxVideos[4].Play();

            LinuxVideoPlayer[4].SetActive(true);
        }

        else if (input == "cd")
        {
            Terminalscreen.SetActive(false);

            if (!linuxVideos[5].isPlaying)
                linuxVideos[5].Play();

            LinuxVideoPlayer[5].SetActive(true);
        }

        else if (input == "mkdir")
        {
            Terminalscreen.SetActive(false);

            if (!linuxVideos[6].isPlaying)
                linuxVideos[6].Play();

            LinuxVideoPlayer[6].SetActive(true);
        }      
      
       


    }

    //Function which gets back to Terminal Screen
    public void GoBackToTerminal()
    {
        foreach(GameObject obj in LinuxVideoPlayer)
        {
            obj.SetActive(false); 
        }

        //Terminal.ClearScreen();

        Terminalscreen.SetActive(true);        

        linuxController.ShowCommandsAvailable();
        
    }

    //Function for opening the keyboard
    public void OpenKeyBoard()
    {
        
        keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);    //Opens the keyboard


        //CheckUserInput();  //Checks the user input
        
        
    }


}
