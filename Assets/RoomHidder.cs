using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomHidder : MonoBehaviour
{

    private SpriteRenderer _spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            _spriteRenderer.color = new Color(0, 0, 0, 0);
        }
    }

    private void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            _spriteRenderer.color = new Color(0, 0, 0, 1);
        }
    }
}
