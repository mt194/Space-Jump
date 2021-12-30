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
		currentLevel.spawnPosition.y += Random.Range(currentLevel.minY, currentLevel.maxY);
		currentLevel.spawnPosition.x = Random.Range(-lw, lw);

		//Creating Start Portal
		Instantiate(sp, currentLevel.spawnPosition, Quaternion.identity);
		currentLevel.spawnPosition.y += Random.Range(currentLevel.minY, currentLevel.maxY);
		currentLevel.spawnPosition.x = Random.Range(-lw, lw);
		sp.transform.position = currentLevel.spawnPosition;

		//Platform between 2 portals
		Instantiate(currentLevel.platformPrefab, currentLevel.spawnPosition, Quaternion.identity);


		//Creating End Portal
		float distanceY = Random.Range(2f, 5f);
		currentLevel.spawnPosition.y += distanceY;
		currentLevel.spawnPosition.x = Random.Range(-lw, lw);
		ep.transform.position = currentLevel.spawnPosition;
	}

}
