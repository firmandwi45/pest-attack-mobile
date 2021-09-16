using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject RootSpawn;
    public float SpawnTimeFactor = 3f;
    public GameObject Coin;

    public List<GameObject> GridA;
    public List<GameObject> GridB;
    public List<GameObject> GridC;
    public List<GameObject> GridD;
    public List<GameObject> GridE;

    private List<List<GameObject>> SpawningGrids = new List<List<GameObject>>();

    private void Start()
    {
        SpawningGrids.Add(GridA);
        SpawningGrids.Add(GridB);
        SpawningGrids.Add(GridC);
        SpawningGrids.Add(GridD);
        SpawningGrids.Add(GridE);

        StartCoroutine(CoinSpawn());
    }

    IEnumerator CoinSpawn()
    {
      //while(true)
      //{
        yield return new WaitForSeconds(SpawnTimeFactor);

          //int rngSpawn = new System.Random().Next(0, 5);
          int rngGrid = new System.Random().Next(0, 4);
          int rngIndex = new System.Random().Next(0, 8);

          //int spawnPointIndex = ((rngSpawn + 1) * (rngGrid + 1) - 1);
          GameObject spawnPoint = SpawningGrids[rngGrid][rngIndex];
          Debug.Log($"Spawn Point: {rngGrid}, {rngIndex}: {spawnPoint.name}, {spawnPoint.transform.position}");

            if(spawnPoint.transform.childCount == 0)
            {
                GameObject coinInstance = Instantiate(Coin, spawnPoint.transform);

              //Instantiate(Coin, ObjectMaster.Instance.Camera.ScreenToWorldPoint(spawnPoint.transform.position));
             
              //GameObject spawn = Instantiate(Coin, spawnPoint.transform);
              //Vector3 fixedPosition = ObjectMaster.Instance.Camera.ScreenToWorldPoint(spawnPoint.transform.position);
              //fixedPosition.z = 0f;
              //spawn.transform.position = fixedPosition;
            }

      //}
    }


}