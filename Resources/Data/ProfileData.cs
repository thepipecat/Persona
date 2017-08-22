using UnityEngine;

namespace ThePipeCat.Persona
{
  [CreateAssetMenuAttribute(fileName = "Char Profile", menuName = "Persona/Profile")]
  public class ProfileData : ScriptableObject
  {
    [System.Serializable]
    private class LifePointsSettings {
      [SerializeField]
      private float m_life;
      [SerializeField]
      private float m_maxLife;

      public float Life {
        get { return m_life; }
        set { m_life = value; }
      }

      public float MaxLife {
        get { return m_maxLife; }
        set { m_maxLife = value; }
      }
    }

    [SerializeField]
    private string m_name = "Persona Name";
    [SerializeField]
    private LifePointsSettings m_lifePoints = new LifePointsSettings();

    public string Name {
      get { return m_name; }
    }

    private void Awake () {

    }
  }
}
