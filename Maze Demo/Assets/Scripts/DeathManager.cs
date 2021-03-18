using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    public Transform respawnPoint;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(Respawn(3.0f, other.gameObject));
        }
    }

    private IEnumerator Respawn(float delay, GameObject obj)
    {
        obj.SetActive(false);
        yield return new WaitForSeconds(delay);
        obj.transform.position = respawnPoint.position;
        obj.SetActive(true);


    }
}
