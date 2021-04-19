using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public GameObject presentPrefab;
    public Transform transformGroup;
    public float spawnNext = 3f;
    public float spawnRate = 2.5f;
    public int presentsCollected;
    public Text counter;

    private void Start()
    {
        presentsCollected = 0;
    }

    private void Update()
    {
        if (Time.time > spawnNext)
        {
            spawnNext = Time.time + spawnRate;
            Spawn();
        }

        counter.text = presentsCollected.ToString();
    }

    private void Spawn()
    {
        var collectibles = Instantiate(presentPrefab);
        collectibles.GetComponent<Transform>().SetParent(transformGroup, false);
        collectibles.GetComponent<Transform>().localPosition = new Vector3(Random.Range(-300, 300), 300, 0);
        collectibles.GetComponent<Transform>().localRotation = Quaternion.identity;
        collectibles.GetComponent<Image>().color = Random.ColorHSV(0f, 1f, 0.80f, 0.80f, 1f, 1f);
    }
}
