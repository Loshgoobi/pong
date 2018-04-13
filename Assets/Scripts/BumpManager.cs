using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpManager : MonoBehaviour {

    public ScoreUI score;
    public GameObject bump;
    public Transform[] spawnPoints;

	// Use this for initialization
	void Start () {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        InvokeRepeating("Spawn", 10, Random.Range(11, 25));
    }
	

    void Spawn()
    {
        // Find a random index between zero and one less than the number of spawn points.
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        // Create an instance of the bump prefab at the randomly selected spawn point's position and rotation.
        Instantiate(bump, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
