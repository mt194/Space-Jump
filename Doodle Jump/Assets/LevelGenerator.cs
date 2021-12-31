using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    public GameObject platformPrefab;
    public GameObject portalPrefab;

    public int numberOfPlatforms = 200;
    public float levelWidth = 3f;
    public float minY = .75f;
    public float maxY = 3f;
    public Vector3 spawnPosition = new Vector3();
    public GameOverMenu GameOverMenu;

    private static Vector3 newPosition = new Vector3();
    public void GameOver(){
        GameOverMenu.Setup(numberOfPlatforms);
    }

    // Use this for initialization
    void Start() {
        for (int i = 0; i < numberOfPlatforms; i++) {
            spawnPosition = getNewDistance(spawnPosition, this);
            if ((int)Random.Range(1, 10) % 5 == 0 && i > 5) { //0.2 probability to make portal
                Instantiate(portalPrefab,spawnPosition,Quaternion.identity);
            }
            else {
               Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            }

        }
    }

    static bool reachableDistance(Vector3 prev,Vector3 after) {
        return (Vector3.Distance(prev, after) <= 5.04);
    }
    

    public Vector3 getNewDistance(Vector3 old, LevelGenerator lg) {
        newPosition.y = float.MaxValue;
        while (!reachableDistance(old, newPosition)) {
            newPosition.y = old.y + Random.Range(lg.minY, lg.maxY);
            newPosition.x = Random.Range(-lg.levelWidth, lg.levelWidth);
        }
        return newPosition;
    }
}
