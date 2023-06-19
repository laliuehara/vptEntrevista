using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PegarSoltar : MonoBehaviour
{
    Vector2 difference = Vector2.zero;

  private void OnMouseDown(){
    difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
  }

  private void OnMouseDrag(){
    transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;
  }
}
