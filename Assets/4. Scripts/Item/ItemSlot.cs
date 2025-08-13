using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    // ������
    public ItemData item;

    // �κ��丮 / ����
    [HideInInspector] public UIInventory inventory;
    public Button button;
    public Image icon;
    public TextMeshProUGUI quatityText;
    private Outline outline;

    public int index;
    public bool equipped;
    public int quantity;

    private void Awake()
    {
        outline = GetComponent<Outline>();
    }

    private void OnEnable()
    {
        outline.enabled = equipped;
    }

    public void Set()
    {
        // �������� ������ ��ĭ ó��
        if (item == null)
        {
            Clear();
            return;
        }

        if (icon != null)
        {
            icon.gameObject.SetActive(true);
            icon.sprite = item.icon;
        }

        if (quatityText != null)
            quatityText.text = (quantity > 1) ? quantity.ToString() : string.Empty;

        if (outline != null)
            outline.enabled = equipped;
    }

    public void Clear()
    {
        item = null;
        quantity = 0;
        equipped = false;

        if (icon != null)
        {
            icon.sprite = null;
            icon.gameObject.SetActive(false); // ��ĭ ǥ��
        }

        if (quatityText != null)
            quatityText.text = string.Empty;

        if (outline != null)
            outline.enabled = false;
    }

    public void OnClickButton()
    {
        inventory.SelectItem(index);
    }
}
