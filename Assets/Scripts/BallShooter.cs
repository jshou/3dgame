using UnityEngine;
using System.Collections;

public class BallShooter : MonoBehaviour {
  void Update() {
    if (Input.GetMouseButtonDown(1)) {
      Camera.main.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
    }
  }
}
