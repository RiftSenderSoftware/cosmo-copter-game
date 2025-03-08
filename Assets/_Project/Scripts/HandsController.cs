using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HandsController : MonoBehaviour
{
    public GameObject leftHand;
    public GameObject leftHandTrigger;
    public GameObject rightHand;
    public GameObject rightHandTrigger;
    public float handMove;
    public bool grabEnabled = false;



    // Update is called once per frame
    void Update()
    {
        // left mouse click input hands forwars
        if (Input.GetMouseButtonDown(0))
        {
            leftHand.transform.Translate(new Vector3(0, 0, handMove));
            leftHandTrigger.SetActive(true);
        }
        if (Input.GetMouseButtonUp(0))
        {
            leftHand.transform.Translate(new Vector3(0, 0, -handMove));
            leftHandTrigger.SetActive(false);
        }



        // right mouse click input hands forwars
        if (Input.GetMouseButtonDown(1))
        {
            rightHand.transform.Translate(new Vector3(0, 0, handMove));
            rightHandTrigger.SetActive(true);

        }
        if (Input.GetMouseButtonUp(1))
        {
            rightHand.transform.Translate(new Vector3(0, 0, -handMove));
            rightHandTrigger.SetActive(false);
        }

        // middle mouse click input hands forwars
        if (Input.GetMouseButtonDown(2))
        {
            leftHand.transform.Translate(new Vector3(1, 0, 0));
            rightHand.transform.Translate(new Vector3(-1, 0, 0));
            grabEnabled = true;
        }
        if (Input.GetMouseButtonUp(2))
        {
            leftHand.transform.Translate(new Vector3(-1, 0, 0));
            rightHand.transform.Translate(new Vector3(1, 0, 0));
            grabEnabled = false;
        }


    }
}
