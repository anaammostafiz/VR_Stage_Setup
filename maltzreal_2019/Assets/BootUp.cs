using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class BootUp : MonoBehaviour
{
    public GameObject BootMenuUI;
    public static bool isGameStart;
    public SteamVR_ActionSet m_ActionSet;
    public SteamVR_Action_Boolean m_BooleanAction;
    public SteamVR_Input_Sources inputSource = SteamVR_Input_Sources.LeftHand;
    // Start is called before the first frame update

    private void Awake()
    {
        m_BooleanAction = SteamVR_Actions._default.GrabPinch;
    }

    void Start()
    {
        BootMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isGameStart = false;
        m_ActionSet.Activate(SteamVR_Input_Sources.LeftHand, 0, true);
    }

    void Update()
    {
        if (m_BooleanAction[SteamVR_Input_Sources.LeftHand].stateDown == true && isGameStart == false)
        {
            BootMenuUI.SetActive(false);
            Time.timeScale = 1f;
            isGameStart = true;
        } 
    }
}

