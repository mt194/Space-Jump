using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    public GameObject platformPrefab;
    public GameObject portalPrefab;

    public int numberOfPlatforms = 200;
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;
    public Vector3 spawnPosition = new Vector3();

    // Use this for initialization
    void Start() {
        for (int i = 0; i < numberOfPlatforms; i++) {
            spawnPosition.y += Random.Range(minY, maxY);                        //random y-axis distance between previous and next component
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);            //random x-axis coordinate for next component
            if ((int)Random.Range(1, 10) % 5 == 0 && i > 5) {                   //small probability to make portal
                Instantiate(portalPrefab,spawnPosition,Quaternion.identity);    //create portal
            }
            else {
               Instantiate(platformPrefab, spawnPosition, Quaternion.identity);  //create platform
            }

        }
    }
}
