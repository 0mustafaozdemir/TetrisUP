using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TriggerCube : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Sýnýr")
        {
            
            var destroy = Spawn.Instance.pieceList[0].GetComponent<TriggerCube>();
            
            var number = GameManager.Instance.scoreInt += (Random.Range(0, 100));
            GameManager.Instance.scor.text = GameManager.Instance.scoreInt.ToString();
            var destroySpawn = Spawn.Instance.pieceList[0].GetComponent<CubeController>();
            var destroySpawnCube = Spawn.Instance.pieceList[0].GetComponent<Spawn>();
            Destroy(destroySpawn);
            Destroy(destroySpawnCube);
            Destroy(destroy);
            Spawn.Instance.pieceListLast.Add(Spawn.Instance.pieceList[0]);
            Spawn.Instance.pieceList.Remove(Spawn.Instance.pieceList[0]);
            Spawn.Instance.ObjectInstantiate();
            Spawn.Instance.pieceList[0].transform.DOMove(new Vector2(Spawn.Instance.zeroPiecePos.transform.position.x, Spawn.Instance.zeroPiecePos.transform.position.y), .50f);
        }

    }
}
