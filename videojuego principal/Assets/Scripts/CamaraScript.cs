using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraScript : MonoBehaviour
{
    public GameObject goku;

    
    void Update()
    {
        Vector3 position = transform.position;
        position.x = goku.transform.position.x;
        transform.position = position;
    }
}
