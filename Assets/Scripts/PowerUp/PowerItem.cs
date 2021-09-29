using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerItem: MonoBehaviour {
  public GameObject floatingTextPrefabs;

  private void OnTriggerEnter(Collider other) {
    if (other.tag == "Player" && other.GetType() == typeof (CapsuleCollider)) {
      Powers();
    }
  }

  public virtual void Powers() {
    
  }
}