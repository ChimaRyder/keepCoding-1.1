using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ProgramManager : MonoBehaviour
{
    [SerializeField] private List<Program> programs = new List<Program>();

    public void openProgram(string openID) {
        for (int i = 0; i < 3; i++) {
            if (programs[i].windowID == openID){
                Debug.Log(programs[i]);
            }
        }

    }

    public void closeProgram(string closeID) {
            for (int i = 0; i < 3; i++) {
            if (programs[i].windowID == closeID){
                //close the program
            }
        }
    }
}
