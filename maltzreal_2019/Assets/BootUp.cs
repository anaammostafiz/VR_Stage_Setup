using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootUp : MonoBehaviour
{
    public GameObject BootMenuUI;
    // Start is called before the first frame update
    void Start()
    {
        BootMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            BootMenuUI.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
