using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(221, 26, 181, 255);
    [SerializeField] Color32 noPackageColor = new Color32(255, 255, 255, 255);
    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage = false;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = noPackageColor;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Watch where you're driving!");
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up!");
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
            spriteRenderer.color = hasPackageColor;
        }
        else if (other.tag == "Package" && hasPackage) {
            Debug.Log("Already carrying a package - Deliver it first!");
        }
        else if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered!");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
