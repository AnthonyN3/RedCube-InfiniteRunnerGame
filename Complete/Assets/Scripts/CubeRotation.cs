using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CubeRotation : MonoBehaviour {

  private Vector3 RotateAmount;  // degrees per second to rotate in each axis. Set in inspector.
  public Slider[] sliders;

    // Update is called once per frame
    void Update () {
        RotateAmount = new Vector3(sliders[0].value, sliders[1].value, sliders[2].value);
        transform.Rotate(RotateAmount* Time.deltaTime);
    }

}
