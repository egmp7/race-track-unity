using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static event Action onPlayerDeath;

    [SerializeField] Transform player;

    void Update()
    {
        if (IsPlayerOutOfBoundary())
        {
            onPlayerDeath?.Invoke(); // checks if there is subscribers
        }
    }

    bool IsPlayerOutOfBoundary()
    {
        if (player.position.y < -30.0f) return true;
        return false;
    }
}
