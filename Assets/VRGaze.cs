using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRGaze : MonoBehaviour
{
    public Image imgGaze;
    public float totalTime = 2;
    public bool gvrStatus = false;
    public float gvrTimer = 0;

    // for teleporting option
    public int distanceOfRay = 300;
    private RaycastHit hit;


    // Update is called once per frame
    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgGaze.fillAmount = gvrTimer / totalTime;
        }

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if (Physics.Raycast(ray, out hit, distanceOfRay))
        {
            //Debug.Log("Inside first if");
            if (imgGaze.fillAmount == 1 && hit.transform.CompareTag("Teleport"))
            {
                //Debug.Log("Searching for Teleport");
                ResetToZero();
                hit.transform.gameObject.GetComponent<Teleport>().TeleportPlayer();
            }

            if (imgGaze.fillAmount == 1 && hit.transform.CompareTag("RotateCube") && gvrStatus)
            {
                //Debug.Log("Searching for Teleport");
                ResetToZero();
                hit.transform.gameObject.GetComponent<SpinCube>().ChangeSpin();
                gvrStatus = false;
            }

        }
    }

    public void GVROn()
    {
        gvrStatus = true;
    }

    public void GVROff()
    {
        gvrStatus = false;
        ResetToZero();
    }

    public void ResetToZero()
    {
        gvrTimer = 0;
        imgGaze.fillAmount = 0;
        gvrStatus = false;
    }
}
