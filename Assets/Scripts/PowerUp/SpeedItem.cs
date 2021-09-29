using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedItem: PowerItem {
  private PlayerMovement _playerMovement;
  private MeshRenderer _itemObject;
  private BoxCollider _boxCollider;

  // Start is called before the first frame update
  void Start() {
    _playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
    _itemObject = this.gameObject.GetComponent<MeshRenderer>();
    _boxCollider = this.gameObject.GetComponent<BoxCollider>();
  }

  public override void Powers() {
    base.Powers();
    _playerMovement.speed += 2;
    _itemObject.enabled = !_itemObject.enabled;
    _boxCollider.enabled = !_boxCollider.enabled;
    Invoke("ResetSpeed", 5);

    var go = Instantiate(floatingTextPrefabs, this.transform.position, Quaternion.identity);
    go.GetComponent<TextMesh>().text = "Speed Increased !!!";
    go.GetComponent<TextMesh>().color = Color.blue;
  }

  private void ResetSpeed() {
    _playerMovement.speed -= 2;
    Destroy(this.gameObject);
  }
}