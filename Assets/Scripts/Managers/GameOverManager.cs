using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager: MonoBehaviour {
  public PlayerHealth playerHealth;
  public float restartDelay = 5f;

  public Text warningText;

  Animator anim;
  float restartTimer;

  void Awake() {
    anim = GetComponent<Animator>();
  }

  void Update() {
    if (playerHealth.currentHealth <= 0) {
      anim.SetTrigger("GameOver");

      restartTimer += Time.deltaTime;

      if (restartTimer >= restartDelay) {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      }
    }
  }

  public void ShowWarning(float enemyDistance) {
    warningText.text = $"! {Mathf.RoundToInt(enemyDistance)} m";
    anim.SetTrigger("Warning");
  }
}