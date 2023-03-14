using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ChangeMask : MonoBehaviour
{
    public ARFaceManager faceManager;
    public GameObject[] faceFilters;
    private int currentFilterIndex = 0;
    


    public void SwitchFilter()
    {
        // Disable the current filter
        faceFilters[currentFilterIndex].SetActive(false);

        // Increment the current filter index
        currentFilterIndex = (currentFilterIndex + 1) % faceFilters.Length;

        // Enable the next filter
        faceFilters[currentFilterIndex].SetActive(true);

        // Set the active face filter
        faceManager.facePrefab = faceFilters[currentFilterIndex];
        Debug.Log("Filtername: " + faceFilters[currentFilterIndex]);
    }

}
