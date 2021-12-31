using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalControl : MonoBehaviour
{
    public LevelGenerator currentLevel;
    public GameObject sp;
    public GameObject ep;
    void start() {
		float lw = currentLevel.levelWidth;
		//Creating Start Portal
		Instantiate(sp, currentLevel.spawnPosition, Quaternion.identity);
		sp.transform.position = currentLevel.spawnPosition = currentLevel.getNewDistance(currentLevel.spawnPosition, currentLevel);

		//Platform between 2 portals           platform can have any position but the endportal should be falling distance
		currentLevel.spawnPosition.y = Random.Range(2f, 5f);
		currentLevel.spawnPosition.x = Random.Range(-lw, lw);
		Instantiate(currentLevel.platformPrefab, currentLevel.spawnPosition, Quaternion.identity);

		//Creating End Portal
		ep.transform.position = currentLevel.spawnPosition = currentLevel.getNewDistance(currentLevel.spawnPosition, currentLevel); ;
	}

}
