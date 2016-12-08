using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
   
    public Transform playerSpawnPoints;
   
    private bool reSpawn = false;
    private Transform[] spawnPoints;
    private bool lastReSpawnToggle = false;

    public GameObject landingAreaPrefab;

	void Start ()
    {
        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
    }
	
	
	void Update ()
    {
	    if(lastReSpawnToggle != reSpawn) {
            Respawn();
            reSpawn = false;
        } else {
            lastReSpawnToggle = reSpawn;
        }
	}


    private void Respawn()
    {
        int i = Random.Range(1, spawnPoints.Length);
        transform.position = spawnPoints[i].transform.position;
    }


   void OnFindClearArea()
    {
        Invoke("DropFlare", 3f);
    }

    void DropFlare()
    {
        Debug.Log("DropFlare landingAreaPrefab Instantiate called");
        Instantiate(landingAreaPrefab, transform.position, transform.rotation);
    }


}
