using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameInventory
{
    public class InventoryView : MonoBehaviour
    {
        [SerializeField]
        private InventoryItem[] slots;

        public void SetItemImage(Sprite sprite, int index)
        {
            slots[index].UpdateSlotSprite(sprite);
        }

        public InventoryItem GetInventoryItem(int index)
        {
            return slots[index];
        }

        public int GetTotalSlotCount()
        {
            return slots.Length;
        }
    }
}