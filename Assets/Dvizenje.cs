using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dvizenje : MonoBehaviour
{
    //VR Main Camera
    public Transform vrCamera;
    
    //Angle at which walk/stop will be triggered (X value of main camera)
    // F - forward ; B - backward
    public float toggleAngleF = 20.0f;
    public float toggleAngleB = -10.0f;

    // movement speed
    public float speedF = 15.0f;
    public float speedB = 5.0f;

    //Should I move forward/bacwards or not
    public bool moveForward;
    public bool moveBackward;

    //CharacterController script
    public CharacterController cc;

    public int numOfCoins = 0;

    public AudioSource audioSrc;
    public AudioClip coinCollectionSound;

    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        //Find the CharacterController
        cc = GetComponentInParent<CharacterController>();

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (vrCamera.eulerAngles.x >= toggleAngleF && vrCamera.eulerAngles.x < 90.0f)
        {
            moveForward = true;
            moveBackward = false;
        }
        else if (vrCamera.eulerAngles.x <= toggleAngleB && vrCamera.eulerAngles.x > -50.0f)
        {
            moveBackward = true;
            moveForward = false;
        }
        else
        {
            moveForward = false;
            moveBackward = false;
        }

        if (moveForward)
        {
            //Find the forward direction
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
            //Tell CharacterController to move forward
            cc.SimpleMove(forward * speedF);
        }
        else if (moveBackward)
        {
            //Move the Rigidbody backwards constantly at the speed you define (the blue arrow axis in Scene view)
            //m_Rigidbody.velocity = -transform.forward * m_Speed;
            Vector3 forward = vrCamera.TransformDirection(-Vector3.forward);
            cc.SimpleMove(forward * speedB);

            //transform.localPosition -= transform.forward * speedB * Time.deltaTime;

            ////Vector3 backward = vrCamera.TransformDirection(Vector3.back);
            //cc.SimpleMove(backward * speedB);

            //Find the backward direction by adding * -1
            //Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
            //cc.SimpleMove(forward * speedB * -1) ;

            //Vector3 bk = vrCamera.TransformDirection(-Vector3.forward);            
            //cc.SimpleMove(bk * speedB);

            //float curSpeed = speedB * Input.GetAxis("Vertical");
            //cc.SimpleMove(forward * curSpeed);

        }


    }

    private void OnTriggerEnter(Collider coin)
    {
        if (coin.gameObject.CompareTag("Coin"))
        {           
            Destroy(coin.gameObject);
            audioSrc.PlayOneShot(coinCollectionSound, 0.6F);
            numOfCoins++;
            scoreText.text = "Score: " + (numOfCoins*50).ToString();
        }
    }
}
