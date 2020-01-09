using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform[] views;
    public float transitionSpeed;
    Transform currentView;


    // Start is called before the first frame update
    void Start()
    {
        //currentView
    }

    void Update()
    {
        // reset to original view
        if(Input.GetKey(KeyCode.Alpha1))
        {
            currentView = views[0];
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            currentView = views[1];
        }

        if (Input.GetKey(KeyCode.Alpha3))
        {
            currentView = views[2];
        }

        if (Input.GetKey(KeyCode.Alpha4))
        {
            currentView = views[3];
        }

        if (Input.GetKey(KeyCode.Alpha5))
        {
            currentView = views[4];
        }

        transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * transitionSpeed);

        Vector3 currentAngle = new Vector3(
            Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.rotation.eulerAngles.x, Time.deltaTime * transitionSpeed),
            Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentView.rotation.eulerAngles.y, Time.deltaTime * transitionSpeed),
            Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentView.rotation.eulerAngles.z, Time.deltaTime * transitionSpeed));

        transform.eulerAngles = currentAngle;
    }

    // LateUpdate to be used in cases of linear interpolation
    void LateUpdate()
    {
        //transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * transitionSpeed);

        //Vector3 currentAngle = new Vector3(
        //    Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.rotation.eulerAngles.x, Time.deltaTime * transitionSpeed),
        //    Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentView.rotation.eulerAngles.y, Time.deltaTime * transitionSpeed),
        //    Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentView.rotation.eulerAngles.z, Time.deltaTime * transitionSpeed));

        //transform.eulerAngles = currentAngle;
    }
}
