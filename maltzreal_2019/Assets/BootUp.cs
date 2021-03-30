using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootUp : MonoBehaviour
{
    public GameObject BootMenuUI;
    public static bool isGameStart;
    // Start is called before the first frame update
    void Start()
    {
        BootMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isGameStart = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && isGameStart == false)
        {
            BootMenuUI.SetActive(false);
            Time.timeScale = 1f;
            isGameStart = true;
        }
    }
}
