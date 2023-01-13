using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class CubeController : MonoBehaviour
{
    public float timer;
    public bool one = false, two = false;
    public Vector3 rotationPoint;
    public static int height = 10;
    public static int widht = 5;
    public float fallTime = 0.8f;
    public bool isDownArrow;
    public static CubeController Instance;
    public float number1 = 0.3860002f;
    public long number2;
    Vector3 vector;
    Vector2 vector2;
    public static Transform[,] grid = new Transform[widht, height];
        
    private void Awake()
    {
        if (Instance == null)
            Instance = this;

    }
    private void Update()
    {
        if (two == true)
        {
            if (Spawn.Instance.objPos.x != -0.5)
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {                   

                    Debug.Log("Left");
                    Spawn.Instance.pieceList[0].transform.position -= new Vector3(1f, 0f, 0f);
                }
            }
        }
        else
        {
            if (Spawn.Instance.objPos.x != 0.5)
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {

                    Debug.Log("Left");
                    Spawn.Instance.pieceList[0].transform.position -= new Vector3(1f, 0f, 0f);
                }
            }
        }
        
        
        if (Spawn.Instance.objPos.x != 8.5)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Debug.Log("Right");
                Spawn.Instance.pieceList[0].transform.position += new Vector3(+1f, 0f, 0f);
            }
        }
        if (Time.time - timer > (Input.GetKey(KeyCode.PageDown) ? fallTime / 2 : fallTime))
        {
            Spawn.Instance.pieceList[0].transform.position += new Vector3(0f, -1f, 0f);
            timer = Time.time;
            Debug.Log("+");
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
                vector = new Vector3(0, 0, -90);
                vector2 = new Vector2(Spawn.Instance.pieceList[0].transform.position.x, Spawn.Instance.pieceList[0].transform.position.y + 0.132f);
                Spawn.Instance.pieceList[0].transform.DORotate(vector, .01f);
            if (one == true)
            {
                Spawn.Instance.pieceList[0].transform.DOMove(vector2, .01f);
            }
              
            
            one = false;
            two = true;
            
           
            
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
          
                vector = new Vector3(0, 0, 0);
                vector2 = new Vector2(Spawn.Instance.pieceList[0].transform.position.x, Spawn.Instance.pieceList[0].transform.position.y - 0.15f);
                Spawn.Instance.pieceList[0].transform.DORotate(vector, .01f);
            if (two == true)
            {
                Spawn.Instance.pieceList[0].transform.DOMove(vector2, .01f);
            }
                
            
            one = true;
            two = false;
           
            
        }
    }
}
