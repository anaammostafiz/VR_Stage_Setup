using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paws : MonoBehaviour
{
    public static bool GameIsPaws = false;
    public GameObject PawsMenuUI;
    public GameObject FPC;
    // Update is called once per frame
    private void Start()
    {
        PawsMenuUI.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
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
        FPC.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_MouseLook.m_cursorIsLocked = true;
    }
    void Pawz()
    {
        PawsMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaws = true;
        FPC.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_MouseLook.m_cursorIsLocked = false;
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
