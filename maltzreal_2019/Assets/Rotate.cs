using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    void OnMouseOver()
    {
        if (Input.GetKey(KeyCode.R))
            this.transform.Rotate(0.0f, 10.0f, 0.0f);
    }

    void Update()
    {
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
    }
}
