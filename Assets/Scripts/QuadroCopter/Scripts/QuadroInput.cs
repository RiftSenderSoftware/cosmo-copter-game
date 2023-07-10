using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityStandardAssets.Cameras;

public class QuadroInput : MonoBehaviour
{
    

    private bool jump;

    float horizontalSpeed = 2.0f;
    float verticalSpeed = 2.0f;

    
    public GameObject quadroCenter;
    public float speed = 100.0f;
    public float rotationSpeed = 100.0f;
    
    // Audio
    public AudioSource flyAudioSource;
    public AudioClip flySound;
    public AudioClip preflySound;

    public GameObject mainModels;
    public GameObject rbModels;
    public GameObject deathCanvas;
    public GameObject flcGm;

    public GameObject[] carrentTrans;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = new Rigidbody();

    }


    // Update is called once per frame
    void FixedUpdate()
    {
        InputKeyboard();
        InputMouse();
        JumpAddForce();
    }
    private void Update()
    {
        //InputTransform();
        if (gameObject.transform.rotation.x >= 30)
        {
            gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.up);
        }

        // JUMP
        if (SimpleInput.GetKey(KeyCode.Space))
        {
            jump = true;
        }
        else
        {
            jump = false;
            
            flyAudioSource.Stop();
        }

        if (SimpleInput.GetKeyDown(KeyCode.Space))
        {
            flyAudioSource.Play();
        }
        if (SimpleInput.GetKeyUp(KeyCode.Space))
        {
            flyAudioSource.Stop();
        }
    }

    private void InputKeyboard()
    {
        float rotationXAxis = SimpleInput.GetAxis("Vertical") * rotationSpeed;
        float rotationZAxis = SimpleInput.GetAxis("Horizontal") * rotationSpeed;

        float rotationYAxis = SimpleInput.GetAxis("HorizontalArrow") * rotationSpeed;
        float moveHorizontal = SimpleInput.GetAxis("VerticalArrow") * rotationSpeed;
        // не работает
        //PlayAudio();


        // Make it move 10 meters per second instead of 10 meters per frame...
        rotationXAxis *= Time.deltaTime;
        rotationZAxis *= Time.deltaTime;
        rotationYAxis *= Time.deltaTime;

        moveHorizontal *= Time.deltaTime;


        // Rotate around our XYZ-axis
        //gameObject.transform.Rotate(rotationXAxis, 0, 0);
        //gameObject.transform.Rotate(0, rotationYAxis, 0);
        //gameObject.transform.Rotate(0, 0, -rotationZAxis);
        gameObject.GetComponent<Rigidbody>().AddRelativeForce(rotationZAxis * speed, 0, 0);

        gameObject.transform.Rotate(0, rotationYAxis, 0);
        
        
        gameObject.GetComponent<Rigidbody>().AddRelativeForce(0, 0, rotationXAxis * speed);
        

        gameObject.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, moveHorizontal, 0) * speed);
    }

    public void PlayAudio()
    {
        if (SimpleInput.GetButtonDown("W")) 
        { 
            flyAudioSource.Play();
            flyAudioSource.volume = 0.5f;
        }
        if (SimpleInput.GetButtonUp("W")) { flyAudioSource.Stop(); }
        
    }
    private void ApplyForce(Rigidbody body)
    {
        Vector3 direction = body.transform.position - transform.position;
        body.AddForceAtPosition(direction.normalized, transform.position);
    }
    private void InputMouse()
    {
        // Get the mouse delta. This is not in the range -1...1
        float h = horizontalSpeed * SimpleInput.GetAxis("Mouse X");
        float v = verticalSpeed * SimpleInput.GetAxis("Mouse Y");

  

        gameObject.transform.Rotate(0, 0, 0);
    }
    private void JumpAddForce()
    {
        if(jump == true)
        {
            gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.up * speed);
        }
        
    }
            
    public void JumpNow()
    {
        jump = true;
    }

    public void PlayerDead()
    {
        /* Отключает рб и коллайдеры у основного объекта для заморорзки камеры
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
        for(int i = 0; quadroCollider.Length != i; i++) 
        {
            quadroCollider[i].enabled = false;
        }
        */
        deathCanvas.SetActive(true);
        var qc = flcGm.GetComponent<QuadroCamera>();
        qc.targetDeath = true;
        mainModels.SetActive(false);
        rbModels.SetActive(true);
    }
}
