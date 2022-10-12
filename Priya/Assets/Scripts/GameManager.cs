using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int score = 0;
    public GameObject [] itemPrefab;
    public Transform leftTran;
    public Transform rightTran;

    public TextMeshPro scoreText;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        InvokeRepeating("SpawnItem", 0, 2);
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score.ToString();   
    }

    public void SpawnItem()
    {
        float RandomXV = Random.Range(leftTran.position.x, rightTran.position.x);
        Vector2 spawnPos = new Vector2(RandomXV, leftTran.position.y);
        int index = Random.Range(0, itemPrefab.Length);
        Instantiate(itemPrefab[index], spawnPos, Quaternion.identity);


    }

    public void IncrementScore(int value)
    {
        score += value;
    }

    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}
