using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    public int heal = 1;

    void Update()
    {
        transform.Translate(Vector2.down * 350 * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        other.GetComponent<PlayerController>().health += heal;
        Debug.Log(other.GetComponent<PlayerController>().health);
        Destroy(gameObject);
    }
}
