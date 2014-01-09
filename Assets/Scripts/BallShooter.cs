using UnityEngine;
using System.Collections;

public class BallShooter : MonoBehaviour {
  void Update() {
    if (Input.GetMouseButtonDown(1)) {
      var ray = Camera.main.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));

      RaycastHit hit;
      if (Physics.Raycast(ray, out hit)) {
        var hittee = hit.transform.gameObject;
        var ballShrinker = hittee.GetComponent<BallShrinker>();
        if (ballShrinker != null) {
          ballShrinker.Shrink();
        }
      }
    }
  }
}
