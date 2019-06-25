using UnityEngine;

namespace GameEntity.Item
{
    [System.Serializable]
    public class Item
    {
        public string itemName;
        public Sprite itemSprite;
        public string itemDescription;
        public DerivedItemType derivedType;// GOD... fuck jsonUtility...
    }

    public enum DerivedItemType
    {
        Weapon = 1,
        Consumable = 2,
        Etc = 3
    }

}

