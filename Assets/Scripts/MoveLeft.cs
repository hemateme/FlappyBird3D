using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private void Update()
    {
         transform.Translate(Vector3.left * (Time.deltaTime * moveSpeed));
    }
}
