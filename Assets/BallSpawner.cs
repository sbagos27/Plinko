using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform spawnLocation;
    void Start()
    {
        
    }

    void Update()
    {
        // if input use, spawn more
        if(Input.GetKey(KeyCode.Space)){
            Vector3 spawnPos = spawnLocation.position;

        //new ball instance
            Instantiate(ballPrefab, spawnPos, Quaternion.identity);
        }
    }

}
