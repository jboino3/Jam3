using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPlay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject menuCanvas; 
    public GameObject mainCamera; 

    public void OnMouseDown()
    {
        // Disable the menu Canvas
        menuCanvas.SetActive(false);
        
        
        mainCamera.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
