using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneToButton : MonoBehaviour
{
    /*private void Update()
    {
        Vector3 planeposition = transform.position;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if ((Physics.Raycast(ray, 100)) && (Input.GetMouseButtonDown(0)))
        {
            planeposition = ray.origin; 
            Debug.Log("Hit something");
            GetComponent<PlaneToButton>().OnMouseDown();
        }
    }*/
    /*void OnMouseOver()
    {
        Vector3 planeposition = transform.position;
    }*/


    [SerializeField] private GameObject objectToDeactivate;
    [SerializeField] private GameObject objectToActivate;
    void OnMouseDown()
    {
        objectToDeactivate.SetActive(false);
        objectToActivate.SetActive(true);
        Debug.Log("Touched something");
    }
}


