using UnityEngine;

public class CameraControlExam06 : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public float offset;
    public Camera targetCamera;
    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 player1Pos = player1.transform.position;
        Vector3 player2Pos = player2.transform.position;
        Vector3 centerPoint = (player1Pos + player2Pos) / 2f;
        targetCamera.transform.position = new Vector3(centerPoint.x, centerPoint.y + 5, centerPoint.z);
        targetCamera.orthographicSize = Mathf.Lerp(targetCamera.orthographicSize, offset + (Mathf.Abs(player1Pos.x - player2Pos.x) + Mathf.Abs(player1Pos.z - player2Pos.z)) / 2f, Time.time);
        //if (centerPoint.x < 0)
        //{
        //    targetCamera.orthographicSize = Mathf.Lerp(targetCamera.orthographicSize, offset + Mathf.Abs(player1Pos.x - player2Pos.x) / 2f, Time.time);
        //}
        //else
        //{
        //    targetCamera.orthographicSize = Mathf.Lerp(targetCamera.orthographicSize, offset + Mathf.Abs(player1Pos.x - player2Pos.x) / 2f, Time.time);
        //}
        //if (centerPoint.z < 0)
        //{
        //    targetCamera.orthographicSize = Mathf.Lerp(targetCamera.orthographicSize, offset + Mathf.Abs(player1Pos.x - player2Pos.x) / 2f, Time.time);
        //}
        //else
        //{
        //    targetCamera.orthographicSize = Mathf.Lerp(targetCamera.orthographicSize, offset + Mathf.Abs(player1Pos.x - player2Pos.x) / 2f, Time.time);
        //}
    }
}