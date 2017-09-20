using UnityEngine;

namespace ThePipeCat.Persona
{
  [CreateAssetMenuAttribute(fileName = "New Quest Profile", menuName = "Persona/Profile")]
  class QuestProfile : ScriptableObject
  {
    private QuestTaskProfile[] m_Tasks;

    public float Progress
    {
      get
      {
        float progress = 0f;
        int tasksCount = m_Tasks.Length;
        float percent = 1f / (float)tasksCount;

        for (int i = 0; i < tasksCount; i++)
        {
          QuestTaskProfile task = m_Tasks[i];

          if (task.Complete)
            progress += percent;
        }

        return progress;
      }
    }
  }
}
