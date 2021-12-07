using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingtrap : MonoBehaviour
{
    public GameObject itemToShootPrefab;
    public float shootStartDelay = 0.1f;
    public float shootInterval = 2f;
    void Start()
    {
        StartCoroutine(ShootObject(shootInterval));
    }
    public IEnumerator ShootObject(float delay)
    {
        yield return new WaitForSeconds(delay + shootStartDelay);
        shootStartDelay = 0f;
        var item = (GameObject)Instantiate(itemToShootPrefab, transform.position, transform.rotation);
        StartCoroutine(ShootObject(shootInterval));
    }
}
