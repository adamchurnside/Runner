using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public float litetime;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, litetime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
