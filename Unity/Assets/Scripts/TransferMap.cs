using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransferMap : MonoBehaviour
{
    public string transferMap;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.instance.isMapChanging = true;
            SceneManager.LoadScene(transferMap);
            CheckPointManager.instance.nowMapName = transferMap;
        }
            
    }

}
