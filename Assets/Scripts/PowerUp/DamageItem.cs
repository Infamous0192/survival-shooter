using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageItem: PowerItem {
  private PlayerShooting _playerShooting;
  private MeshRenderer _itemObject;
  private BoxCollider _boxCollider;

  // Start is called before the first frame update
  void Start() {
    _playerShooting = GameObject.Find("GunBarrelEnd").GetComponent < PlayerShooting > ();
    _itemObject = this.gameObject.GetComponent<MeshRenderer>();
    _boxCollider = this.gameObject.GetComponent<BoxCollider>();
  }

  public override void Powers() {
    base.Powers();

    _playerShooting.damagePerShot *= 2;

    _itemObject.enabled = !_itemObject.enabled;

    _boxCollider.enabled = !_boxCollider.enabled;

    Invoke("resetDamage", 5);

    var go = Instantiate(floatingTextPrefabs, this.transform.position, Quaternion.identity);
    go.GetComponent<TextMesh>().text = "Damage Increased !!!";
    go.GetComponent<TextMesh>().color = Color.red;
  }

  private void resetDamage() {
    _playerShooting.damagePerShot /= 2;
    Destroy(this.gameObject);
  }
}