using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    private Movement move;

    private void Awake()
    {
        move = GetComponent<Movement>();
    }

    private void FixedUpdate()
    {
        DestroyAllSaveData();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger"))
        {
            PlayerPrefs.SetFloat(move.GetPos(), other.transform.position.z);
            PlayerPrefs.Save();
        }
    }

    private void DestroyAllSaveData()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
