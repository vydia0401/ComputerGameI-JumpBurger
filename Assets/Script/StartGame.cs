using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public bool startGame = false;
    public InstantiateLevels instantiateLevels;
    // Start is called before the first frame update
    public void StartGameNow()
    {
        startGame = true;
        instantiateLevels.StartInstantiate();
        GameObject buttons = GameObject.Find("SettingBackground");
        GameObject instruction = GameObject.Find("InstructionImg");
        Destroy(buttons);
        Destroy(instruction);

    }
}
