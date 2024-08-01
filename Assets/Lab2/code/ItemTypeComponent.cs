using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Euaungkul.GameDev3.Chapter1
{
    public class ItemTypeComponent : MonoBehaviour
    {
        [SerializeField] protected ItemType m_ItemType;

        public ItemType Type
        {
            get { return m_ItemType; }
            set { m_ItemType = value; }
        }
    }
}