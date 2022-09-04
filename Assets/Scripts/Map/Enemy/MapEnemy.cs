using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(Collision))]
public class MapEnemy : MonoBehaviour, IBattleable
{
    [SerializeField]
    [Header("�J�ڂ���o�g���V�[����")]
    string _battleSceneName;

    public void Battle()
    {
        SceneLoder.Instance.LoadScene(_battleSceneName);
    }
}
