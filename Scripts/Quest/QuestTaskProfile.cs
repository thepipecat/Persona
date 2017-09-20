using UnityEngine;

namespace ThePipeCat.Persona
{
  [CreateAssetMenuAttribute(fileName = "New Task Profile", menuName = "Persona/Profile")]
  public class QuestTaskProfile : ScriptableObject
  {
    private QuestTaskType m_Type;
    private bool m_Complete;
    private Persona[] m_Targets;

    // Assassination related:

    // Item collection related:

    private PersonaItem[] m_Items;

    public QuestTaskType Type
    {
      get
      {
        return m_Type;
      }
    }

    public bool Complete
    {
      get
      {
        return m_Complete;
      }
    }

    public QuestTaskProfile (QuestTaskType type = QuestTaskType.Assassination)
    {
      m_Type = type;
      m_Complete = false;
    }

    public void Verify()
    {
      switch (m_Type)
      {
        case QuestTaskType.Assassination:
          int targetsCount = m_Targets.Length;
          float lifeRemains = 0f;

          for (int i = 0; i < targetsCount; i++)
          {
            Persona target = m_Targets[i];

            lifeRemains += target.Profile.Stats.Life;
          }

          m_Complete = lifeRemains > 0f ? false : true;

          break;
        case QuestTaskType.ItemCollection:

          break;
      }
    }
  }
}
