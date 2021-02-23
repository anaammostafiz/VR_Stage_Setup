using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodMode : MonoBehaviour
{
    public GameObject FPC;
    public GameObject model_1B;
    public GameObject model_2B;

    public void Spawn1B()
    {
        GameObject Clone = Instantiate(model_1B);
        Clone.transform.position = new Vector3(0, 0, 0);
        Mooodel.GameIsModel = false;
        Time.timeScale = 1f;
        Paws.GameIsPaws = false;
        FPC.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_MouseLook.m_cursorIsLocked = true;
    }

    public void Spawn2B()
    {
        GameObject Clone = Instantiate(model_2B);
        Clone.transform.position = new Vector3(0, 0, 0);
        Mooodel.GameIsModel = false;
        Time.timeScale = 1f;
        Paws.GameIsPaws = false;
        FPC.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_MouseLook.m_cursorIsLocked = true;
    }
}
