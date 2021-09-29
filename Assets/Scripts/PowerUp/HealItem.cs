using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealItem: PowerItem {
  private PlayerHealth _playerHealth;
  private Slider sliderUpdate;

  // Start is called before the first frame update
  void Start() {
    base.Powers();
    _playerHealth = GameObject.Find("Player").GetComponent<PlayerHealth>();
    sliderUpdate = GameObject.Find("HeartSlider").GetComponent<Slider>();
  }

  public override void Powers() {
    if (_playerHealth.currentHealth < 100)
      _playerHealth.currentHealth += 25;

    if (_playerHealth.currentHealth >= 100)
      _playerHealth.currentHealth = 100;

    sliderUpdate.value = _playerHealth.currentHealth;
    Destroy(this.gameObject);

    var go = Instantiate(floatingTextPrefabs, this.transform.position, Quaternion.identity);
    go.GetComponent<TextMesh>().text = "Health Increased !!!";
    go.GetComponent<TextMesh>().color = Color.green;
  }
}