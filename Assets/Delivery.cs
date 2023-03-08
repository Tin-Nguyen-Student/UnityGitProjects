using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 noPackageColor = new Color32 (1, 1 ,1 ,1);
    [SerializeField] Color32 hasPackageColor = new Color32 (1, 1, 1, 1);
    [SerializeField] float destroyDelay = 0.5F;
    bool hasPackage;
    SpriteRenderer spriteRenderer;
    public  void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("You Belong To The Streets!");
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }
        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package Delivered");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
