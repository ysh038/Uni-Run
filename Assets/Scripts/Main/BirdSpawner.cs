using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    public GameObject birdPrefab; // 생성할 새의 원본 프리팹
    private GameObject[] birds; // 미리 생성한 새들
    public int count = 3;
    private int currentindex = 0;

    public float birdtimeBetSpawnMin = 10f; // 다음 배치까지의 시간 간격 최솟값
    public float birdtimeBetSpawnMax = 15f; // 다음 배치까지의 시간 간격 최댓값
    private float birdtimeBetSpawn; // 다음 배치까지의 시간 간격
    private float birdlastSpawnTime; // 마지막 배치 시점

    public float yMin = 2f; // 배치할 위치의 최소 y값
    public float yMax = 6f; // 배치할 위치의 최대 y값
    private float xPos = 20f; // 배치할 위치의 x 값

    private Vector2 poolPosition = new Vector2(0, -25); // 초반에 생성된 bird를 화면 밖에 숨겨둘 위치

    void Start()
    {
        birds = new GameObject[count];
        for (int i = 0; i < count; i++)
        {
            birds[i] = Instantiate(birdPrefab, poolPosition, Quaternion.identity);
        }
        //birds = Instantiate(birdPrefab, poolPosition, Quaternion.identity);
        

        birdlastSpawnTime = 0f;
        birdtimeBetSpawn = Random.Range(birdtimeBetSpawnMin, birdtimeBetSpawnMax);
        //timeBetSpawn = Random.Range(timeBetSpawnMin, timeBetSpawnMax);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.isGameover)
        {
            return;
        }

        if (Time.time >= birdlastSpawnTime + birdtimeBetSpawn)
        {
            birdlastSpawnTime = Time.time;
            birdtimeBetSpawn = Random.Range(birdtimeBetSpawnMin, birdtimeBetSpawnMax);
            float yPos = Random.Range(yMin, yMax);

            birds[currentindex].SetActive(false);
            birds[currentindex].SetActive(true);

            birds[currentindex].transform.position = new Vector2(xPos, yPos);
            currentindex++;

            if(currentindex >= count)
            {
                currentindex = 0;
            }
        }
    }
}
