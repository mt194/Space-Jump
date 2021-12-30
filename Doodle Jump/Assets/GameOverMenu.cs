using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverMenu : MonoBehaviour
{
    public Text pointsText;
    public void Setup(int score){
      gameObject.SetActive(true);
      Debug.Log(score +" score ");
      pointsText.text = score.ToString() + " POINTS";
    }
  public void GoToHomePage() {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
  }
  public void GoToHomePageFromGameOverScreen() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
  }
}
