using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePanel : MonoBehaviour
{
    [SerializeField] private List<GameObject> objectsToDeactivate = new List<GameObject>();
    [SerializeField] private List<GameObject> objectsToActivate = new List<GameObject>();

    public void TransitionToNextPanel()
    {
        foreach (GameObject obj in objectsToDeactivate)
        {
            if (obj != null) // Check if the object is not null to avoid errors
                obj.SetActive(false);
        }

        foreach (GameObject obj in objectsToActivate)
        {
            if (obj != null) // Check if the object is not null to avoid errors
                obj.SetActive(true);
        }
    }
}