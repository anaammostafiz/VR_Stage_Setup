using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Paws : MonoBehaviour
{
    public static bool GameIsPaws = false;
    public GameObject PawsMenuUI;
    public SteamVR_ActionSet m_ActionSet;
    public SteamVR_Action_Boolean m_BooleanAction;

    private void Awake()
    {
        m_BooleanAction = SteamVR_Actions._default.GrabGrip;
    }
    private void Start()
    {
        PawsMenuUI.SetActive(false);
        m_ActionSet.Activate(SteamVR_Input_Sources.Any, 0, true);
    }
    void Update()
    {
        if (m_BooleanAction[SteamVR_Input_Sources.Any].stateDown == true && BootUp.isGameStart)
        {
            if (GameIsPaws)
            {
                Rezoom();
            }
            else
            {
                Pawz();
            }
        }
    }
    public void Rezoom()
    {
        PawsMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaws = false;
    }
    void Pawz()
    {
        PawsMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaws = true;
    }
    public void Qwit()
    {
        Debug.Log("Quitting...");
        if (UnityEditor.EditorApplication.isPlaying == true)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
        else
        {
            Application.Quit();
        }
    }
    public void Mawdels()
    {
        PawsMenuUI.SetActive(false);
        Mooodel.GameIsModel = true;
    }
    public void GoodEyeMate()
    {
        PawsMenuUI.SetActive(false);
        GodEye.GameIsLook = true;
    }
}
