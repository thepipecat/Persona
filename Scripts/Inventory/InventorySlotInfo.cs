using UnityEngine;

namespace ThePipeCat.Persona
{
  /// <summary>
  /// Inventory slot info.
  /// </summary>
  [System.Serializable]
  public class InventorySlotInfo : System.Object
  {
    public ItemProfile Item = null;
    public int Count = 0;
    public int Index = -1;

    public InventorySlotInfo (ItemProfile item, int count, int index = -1) {
      Item = item;
      Count = count;
      Index = index;
    }
  }
}