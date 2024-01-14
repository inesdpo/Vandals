using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneToButton : MonoBehaviour
{
    [SerializeField] private GameObject objectToDeactivate;
    [SerializeField] private GameObject objectToActivate;

    public void OnMouseDown()
    {
        objectToDeactivate.SetActive(false);
        objectToActivate.SetActive(true);
        
    }
}


