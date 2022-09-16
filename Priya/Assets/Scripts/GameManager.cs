using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject itemPrefab;
    public Transform leftTran;
    public Transform rightTran;
    void Start()
    {
        InvokeRepeating("SpawnItem", 0, 2);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnItem()
    {
        float RandomXV = Random.Range(leftTran.position.x, rightTran.position.x);
        Vector2 spawnPos = new Vector2(RandomXV, leftTran.position.y);
        Instantiate(itemPrefab, spawnPos, Quaternion.identity);


    }
}
