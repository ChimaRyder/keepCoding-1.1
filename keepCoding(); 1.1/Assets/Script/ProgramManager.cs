using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ProgramManager : MonoBehaviour
{
    [SerializeField] private List<Program> programs = new List<Program>();

    public void openProgram(string openID) {
        for (int i = 0; i < programs.Count; i++) {
            if (programs[i].windowID == openID){
                if (programs[i].window.activeSelf)
                {
                    programs[i].window.SetActive(false);
                    break;
                }
                
                programs[i].window.SetActive(true);
            }
            else
            {
                programs[i].window.SetActive(false);
            }
        }

    }

    public void closeProgram(string closeID) {
        for (int i = 0; i < 3; i++) {
            if (programs[i].windowID == closeID){
                programs[i].window.SetActive(false);
            }
        }
    }
}
