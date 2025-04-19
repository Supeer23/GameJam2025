using UnityEngine;

public class cameraManager : MonoBehaviour
{
    private boardGenerator board;
    private Camera cam;
    private int Height;
    private int Width;
    private void Start() {
        board = GameObject.FindGameObjectWithTag("GameManager").GetComponent<boardGenerator>();
        Height = board.getHeight();
        Width = board.getWidth();
        cam = GetComponent<Camera>();
        cam.transform.position = new Vector3 (Height/2, Width/2, -10);
    }
}
