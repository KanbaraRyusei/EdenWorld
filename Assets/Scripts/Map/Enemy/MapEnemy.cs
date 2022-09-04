using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapEnemy : MonoBehaviour, IBattleable
{
    [SerializeField]
    [Header("�J�ڂ���o�g���V�[����")]
    string _battleSceneName;

    Collider _collider;

    void Awake()
    {
        _collider = GetComponent<CapsuleCollider>();
    }

    public void Battle()
    {
        SceneLoder.Instance.LoadScene(_battleSceneName);
    }
}
