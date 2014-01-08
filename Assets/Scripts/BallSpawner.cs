using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {
  public GameObject BallPrefab;

  void Update() {
    if (Input.GetMouseButtonDown(0)) {
      var ball = GameObject.Instantiate(BallPrefab, transform.position, transform.rotation) as GameObject;
      ball.GetComponent<Rigidbody>().AddForce(transform.forward * 1500, ForceMode.Impulse);
    }
  }
}
