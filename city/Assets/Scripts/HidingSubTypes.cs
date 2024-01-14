using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidingSubTypes : MonoBehaviour
{
    public GameObject Blocker;

    public void Start()
    {
        Blocker.gameObject.SetActive(false);
    }

    public void Switch()
    {
        if (Blocker.activeSelf == false) Blocker.SetActive(true);
        else Blocker.SetActive(false);
    }
}