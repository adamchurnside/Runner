using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0;
    public Renderer backgroundRenderer;
    

    // Update is called once per frame
    void Update()
    {
        backgroundRenderer.material.mainTextureOffset = new Vector2(Time.time * speed, 0f);
    }
}
