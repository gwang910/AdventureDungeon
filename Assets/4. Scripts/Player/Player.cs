using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerController controller;
    public PlayerCondition condition;
    public Equipment equip;

    public ItemData itemData;
    public Action addItem;

    public Transform dropPosition;

    private void Awake()
    {
        CharacterManager.Instance.Player = this;
        controller = GetComponent<PlayerController>();
        condition = GetComponent<PlayerCondition>();
        equip = GetComponent<Equipment>();

        // ������ ������ ������ ��� ������ �ڵ� ����
        if (dropPosition == null)
        {
            var go = new GameObject("DropPoint");
            go.transform.SetParent(transform);
            go.transform.localPosition = new Vector3(0f, 0f, 1.0f); // �÷��̾� �� 1m
            dropPosition = go.transform;
        }
    }
}
