using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeZone : MonoBehaviour
{
    public GameObject SafeZoneText;

    public void OnTriggerEnter() 
    {
        SafeZoneText.SetActive(true);
    }

    public void OnTriggerExit() 
    {
        SafeZoneText.SetActive(false);
    }
}
