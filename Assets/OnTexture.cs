using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnTexture : MonoBehaviour
{
    public Texture icy;
    void Start()
    {
        GetComponent<RawImage>().texture = icy;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
