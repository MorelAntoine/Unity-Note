using UnityEngine;

namespace UniCraft.Note
{
  /// <inheritdoc/>
  /// <summary>
  /// Module to add note to a GameObject
  /// </summary>
  [AddComponentMenu("UniCraft/Note")]
  public sealed class Note : MonoBehaviour
  {
    public string             Author;
    [TextArea] public string  Content;
    public Color              Status;
    public string             Title;
  }
}
