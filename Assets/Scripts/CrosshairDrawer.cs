using UnityEngine;
using System.Collections;

public class CrosshairDrawer : MonoBehaviour {
  public Texture2D CrosshairTexture;
  private Rect Position;
  private const int CROSSHAIR_SIZE = 100;

  void Start() {
    var crossX = (Screen.width - CROSSHAIR_SIZE) / 2;
    var crossY = (Screen.height - CROSSHAIR_SIZE) / 2;

    Position = new Rect(crossX, crossY, CROSSHAIR_SIZE, CROSSHAIR_SIZE);
  }

  void OnGUI() {
    GUI.DrawTexture(Position, CrosshairTexture);
  }
}
