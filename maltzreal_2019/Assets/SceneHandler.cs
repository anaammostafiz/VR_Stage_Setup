using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Valve.VR.Extras;


public class SceneHandler : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;
    public GameObject canvas;

    void Awake()
    {
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;
    }

    public void PointerClick (object sender, PointerEventArgs e)
    {
        if (e.target.name == "ResumeButton")
        {
            Debug.Log("ResumeButton was clicked");
            canvas.GetComponent<Paws>().Rezoom();
        }
        if (e.target.name == "ModelsButton")
        {
            Debug.Log("ModelsButton was clicked");
            canvas.GetComponent<Paws>().Mawdels();
        }
        if (e.target.name == "1B_Button")
        {
            Debug.Log("1B_Button was clicked");
            canvas.GetComponent<GodMode>().Spawn1B();
        }
        if (e.target.name == "2B_Button")
        {
            Debug.Log("2B_Button was clicked");
            canvas.GetComponent<GodMode>().Spawn2B();
        }
    }

    public void PointerInside (object sender, PointerEventArgs e)
    {
        if (e.target.name == "ResumeButton")
        {
            Debug.Log("ResumeButton was entered");
        }
        if (e.target.name == "ModelsButton")
        {
            Debug.Log("ModelsButton was entered");
        }
        if (e.target.name == "1B_Button")
        {
            Debug.Log("1B_Button was entered");
        }
        if (e.target.name == "2B_Button")
        {
            Debug.Log("2B_Button was entered");
        }
    }

    public void PointerOutside(object sender, PointerEventArgs e)
    {
        if (e.target.name == "object test")
        {
            Debug.Log("ResumeButton was exited");
        }
        if (e.target.name == "ModelsButton")
        {
            Debug.Log("ModelsButton was exited");
        }
        if (e.target.name == "1B_Button")
        {
            Debug.Log("1B_Button was exited");
        }
        if (e.target.name == "2B_Button")
        {
            Debug.Log("2B_Button was exited");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
