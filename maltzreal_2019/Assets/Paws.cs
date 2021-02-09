using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paws : MonoBehaviour
{
    public static bool GameIsPaws = false;
    public GameObject PawsMenuUI;
    // Update is called once per frame
    private void Start()
    {
        PawsMenuUI.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
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
}
