using UnityEngine;
using System.Collections;

public class DestroyComponent : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            Destroy(GetComponent<MeshRenderer>());
        }
    }
}