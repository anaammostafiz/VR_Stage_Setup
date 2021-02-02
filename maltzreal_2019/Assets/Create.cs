using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{

    public GameObject Duplicate;
    void OnMouseDown()
    {
        GameObject Clone = Instantiate(Duplicate);
        Clone.transform.position = new Vector3(0, 0, 0);

    }
}
