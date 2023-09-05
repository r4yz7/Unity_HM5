using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainTeleport : MonoBehaviour
{
    public int sceneId=1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<HulkMove>() != null)
        {
            SceneManager.LoadScene(sceneId);
        }
    }
}
