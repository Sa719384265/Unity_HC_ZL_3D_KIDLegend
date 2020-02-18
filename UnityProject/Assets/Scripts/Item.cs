using UnityEngine;

public class Item : MonoBehaviour
{
    /// <summary>
    /// 是否過關，過關時就前往玩家位置
    /// </summary>
    [HideInInspector]
    public bool pass;

    private Transform player;

    private void Start()
    {
        player = GameObject.Find("鼠王").transform;
        HandleCollision();
    }

    private void Update()
    {
        GoToPlayer();
    }
    private void HandleCollision()
    {
        Physics.IgnoreLayerCollision(10, 8);
        Physics.IgnoreLayerCollision(10, 9);
    }

    private void GoToPlayer()
    {
        if (pass)
        {
            Vector3.Lerp(transform.position, player.position, 0.75f * Time.deltaTime * 10);
        }
    }
}
