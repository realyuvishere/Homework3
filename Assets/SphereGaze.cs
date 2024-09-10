using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGaze : MonoBehaviour
{
    private Renderer _myRenderer;

    public void Start()
    {
        _myRenderer = GetComponent<Renderer>();
        SetMaterial(false);
    }

    
    public void OnPointerEnter()
    {
        SetMaterial(true);
    }

    public void OnPointerExit()
    {
        SetMaterial(false);
    }

 
    private void SetMaterial(bool gazedAt)
    {
        _myRenderer.material.color = gazedAt ? Color.black : Color.white;
    }
}
