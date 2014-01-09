using UnityEngine;
using System.Collections;

public class BallShrinker : MonoBehaviour {
  public void Shrink() {
    gameObject.transform.localScale = new Vector3(2, 2, 2);
  }
}
