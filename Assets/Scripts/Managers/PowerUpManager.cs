using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager: MonoBehaviour {
  public GameObject[] powersItem;

  void Start() {
    Invoke("SpawnPower", 6);
  }

  private void SpawnPower() {
    int randomPower = Random.Range(0, 3);
    Vector3 powerLocation = new Vector3(Random.Range(-20, 20), 1, Random.Range(-20, 20));
    Instantiate(powersItem[randomPower], powerLocation, Quaternion.identity);
    Invoke("SpawnPower", 6);

  }
}