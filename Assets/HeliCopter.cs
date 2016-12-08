using UnityEngine;
using System.Collections;

public class HeliCopter : MonoBehaviour
{
    public AudioClip callSound;
    private bool called = false;
    private Rigidbody rigidBody;
    
    void Start ()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
	

	void Update ()
    {

        if (Input.GetButtonDown("CallHeli") && !called)
        {
                
        }

	}

    void  OnDispatchHelicopter()
    {
        print("Helicopter called");
        rigidBody.velocity = new Vector3(0, 0, 50f);
        called = true;
    }

}
