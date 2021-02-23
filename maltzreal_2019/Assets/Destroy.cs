using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    void OnMouseOver()
    {
        if (Input.GetKey(KeyCode.X))
        {
            Destroy(gameObject);
        }
    }
}
