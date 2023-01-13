using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Spawn : MonoBehaviour
{
    public List<GameObject> pieceList = new List<GameObject>();
    public int number;
    public List<bool> test = new List<bool>();
    public List<GameObject> pieceListLast = new List<GameObject>();
    public List<GameObject> fakePieceList = new List<GameObject>();
    public GameObject zeroPiecePos;
    private static System.Random rng = new System.Random();
    public static Spawn Instance;
    public Vector2 objPos;
    private void Start()
    {
        ObjectInstantiate();
        pieceList[0].transform.DOMove(new Vector2(zeroPiecePos.transform.position.x,zeroPiecePos.transform.position.y), .50f);
    }
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
    private void Update()
    {
        if (test.Count == 12)
        {

        }
        objPos = Spawn.Instance.pieceList[0].transform.position;
        if (objPos.y == 1.382999)
        {
            pieceList.Remove(Spawn.Instance.pieceList[0]);
            ObjectInstantiate();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ObjectInstantiate();
        }
    }
    public void ShuffleController()
    {
        int n = pieceList.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            var value = pieceList[k];
            pieceList[k] = pieceList[n];
            pieceList[n] = value;
        }
    }

    public void ObjectInstantiate()
    {
        var go = Instantiate(fakePieceList[Random.Range(0, fakePieceList.Count)], transform.position, Quaternion.identity);        
        pieceList.Add(go);
        pieceList[0].AddComponent<TriggerCube>();     
        pieceList[0].AddComponent<CubeController>();
        ShuffleController();      
    }    
}
