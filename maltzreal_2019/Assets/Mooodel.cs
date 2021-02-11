using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mooodel : MonoBehaviour
{
    public GameObject ModelMenuUI;
    public static bool GameIsModel = false;
    public GameObject FPC;
    // Start is called before the first frame update
    private void Start()
    {
        ModelMenuUI.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            ModelMenuUI.SetActive(false);
            GameIsModel = false;
        }

        if (GameIsModel == true)
        {
            ModelMenuUI.SetActive(true);
            FPC.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_MouseLook.m_cursorIsLocked = false;
        }
        else
        {
            ModelMenuUI.SetActive(false);
        }
    }
    
}
