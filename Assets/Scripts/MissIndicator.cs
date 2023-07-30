using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissIndicator : MonoBehaviour
{
    private float time;
    private void FixedUpdate()
    {
        time += Time.deltaTime;
        transform.position = new Vector2(transform.position.x, transform.position.y + 1f * Time.deltaTime);
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1 - (1f * time));
        if (time > 1f)
            Destroy(gameObject);
    }
}
