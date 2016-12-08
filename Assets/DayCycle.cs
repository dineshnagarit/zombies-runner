using UnityEngine;
using System.Collections;

public class DayCycle : MonoBehaviour
{

    [Tooltip ("Number of minutes per seconds that pass, try 60")]
    public float minutesPerSecond;

    /*private Quaternion StartRotation;

	void Start ()
    {
        StartRotation = transform.rotation;
    } */

	void Update ()
    {
        float angleThisFrame = Time.deltaTime / 360 * minutesPerSecond;
        transform.RotateAround(transform.position, Vector3.forward, angleThisFrame);	
	}


}
