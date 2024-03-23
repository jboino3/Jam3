using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trainchoice : MonoBehaviour
{
    public Material clickedMaterial;
    public Trainmove train;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        GetComponent<Renderer>().material = clickedMaterial;
        train.SkipWaypoints();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
