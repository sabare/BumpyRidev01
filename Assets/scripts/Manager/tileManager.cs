using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] tilePrefabs;
    private List<GameObject> activeTiles = new List<GameObject>();
    void Start()
    {
        GameObject start = Instantiate(tilePrefabs[0],new Vector3(0,0.5f,-30) , Quaternion.identity);
        activeTiles.Add(start);

        GameObject start1 = Instantiate(tilePrefabs[0],new Vector3(0,0.5f,0) , Quaternion.identity);
        activeTiles.Add(start1);

        GameObject start2 = Instantiate(tilePrefabs[0],new Vector3(0,0.5f,30) , Quaternion.identity);
        activeTiles.Add(start2);

        GameObject start3 = Instantiate(tilePrefabs[1],new Vector3(0,0.5f,60) , Quaternion.identity);
        activeTiles.Add(start3);
        
        GameObject start4 = Instantiate(tilePrefabs[2],new Vector3(0,0.5f,90) , Quaternion.identity);
        activeTiles.Add(start4);
    }


    public void spawnTile(int tileIndex){

        GameObject go = Instantiate(tilePrefabs[tileIndex], new Vector3(0, 0.5f, 120), Quaternion.identity);
        activeTiles.Add(go);
    }

    public void deleteTile(){

        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}
