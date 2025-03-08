using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Counter : MonoBehaviour
{
    public int cout;
    public int coutChange = 3;

    public TextMeshProUGUI textCouter;

    private void Update()
    {
        if(cout != coutChange)
        {
            cout = coutChange;
            textCouter.text = "" + cout;

            if(cout <= 0)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
