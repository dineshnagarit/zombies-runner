using UnityEngine;
using System.Collections;

public class RadioSystem : MonoBehaviour
{
    public AudioClip initialHeliCall;
    public AudioClip initiaCallReply;

    private AudioSource audioSource;

    void Start ()
    {
        audioSource = GetComponent<AudioSource>();
    }
	
	void OnMakeInitialHeliCall()
    {
        print(name + "OnMakeInitialHeliCall");
        audioSource.clip = initialHeliCall;
        audioSource.Play();
        Invoke("InitialReply", initialHeliCall.length + 1f);
    }

    void InitialReply()
    {
        audioSource.clip = initiaCallReply;
        audioSource.Play();
        BroadcastMessage("OnDispatchHelicopter");
    }
}
