using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodMode : MonoBehaviour
{
    public GameObject FPC;
    public GameObject chair;

    public void ChairSpawn()
    {
        GameObject Clone = Instantiate(chair);
        Clone.transform.position = new Vector3(0, 0, 0);
        Mooodel.GameIsModel = false;
        Time.timeScale = 1f;
        Paws.GameIsPaws = false;
        FPC.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_MouseLook.m_cursorIsLocked = true;
    }
}
