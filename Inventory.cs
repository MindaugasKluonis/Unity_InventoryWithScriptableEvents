using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameEntity.Item;

namespace GameInventory
{
    public class Inventory
    {
        private Item[] items;

        public Inventory()
        {
            items = new Item[9];
        }

        public void AddItem(Item item, int index)
        {
            items[index] = item;
        }

        public void RemoveItem(int index)
        {
            items[index] = null;
        }

        public bool IsEmptyAt(int index)
        {
            return items[index] == null;
        }

        public Item GetItem(int index)
        {
            return items[index];
        }

        public int GetInventorySize()
        {
            return items.Length;
        }
    }
}