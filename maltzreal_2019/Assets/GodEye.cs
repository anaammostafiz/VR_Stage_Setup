using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodEye : MonoBehaviour
{
    public GameObject FPC;
    public GameObject ThirdCam;
    public static bool GameIsLook = false;

    // Start is called before the first frame update
    void Start()
    {
        FPC.SetActive(true);
        ThirdCam.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            FPC.SetActive(true);
            ThirdCam.SetActive(false);
            GameIsLook = false;
            Paws.GameIsPaws = false;
        }
        if (GameIsLook == true)
        {
            FPC.SetActive(false);
            ThirdCam.SetActive(true);
        }
    }
}
