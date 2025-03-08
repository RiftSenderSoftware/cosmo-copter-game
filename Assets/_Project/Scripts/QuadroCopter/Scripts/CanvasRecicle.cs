using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasRecicle : MonoBehaviour
{
    public GameObject firstCanvas;
    public GameObject secondCanvas;

    public void CanvasDisableFirst()
    {
        firstCanvas.SetActive(false);
        secondCanvas.SetActive(true);
    }
    public void CanvasEnableFirst()
    {
        firstCanvas.SetActive(true);
        secondCanvas.SetActive(false);
    }
}
