using UnityEngine;
using System.Collections;

public class DestoryOther : MonoBehaviour
{
    public GameObject other;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Destroy(other);
        }
    }
}