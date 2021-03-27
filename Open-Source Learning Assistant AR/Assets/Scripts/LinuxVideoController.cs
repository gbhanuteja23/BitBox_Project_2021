using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video; 

public class LinuxVideoController : MonoBehaviour
{
    public GameObject Terminalscreen; 

    public GameObject[] LinuxVideoPlayer;    //Array of GameObject storing all the videos of respective commands

    public VideoPlayer[] linuxVideos; 

    LinuxTerminalController linuxController;

    // Start is called before the first frame update
    void Start()
    {
        linuxController = GetComponent<LinuxTerminalController>(); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //This function gets called when user inputs anything on Terminal
    void OnUserInput(string input)
    {
        if(input == "cat")
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

        else
        {
            Terminal.WriteLine("\n Invalid Command Entered!");

            //Terminal.ClearScreen();

            linuxController.ShowCommandsAvailable(); 
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

}
