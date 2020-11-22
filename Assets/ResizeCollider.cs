using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BoxCollider boxCollider = gameObject.AddComponent<BoxCollider>();
        MeshRenderer renderer = gameObject.GetComponent<MeshRenderer>();
        boxCollider.size = renderer.bounds.size;
        boxCollider.center = renderer.bounds.center;
    }
}
