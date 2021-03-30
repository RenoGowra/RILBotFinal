namespace Microsoft.Teams.Apps.FAQPlusPlus.Common.Models
{
  using Newtonsoft.Json;

  /// <summary>
  /// Adaptive Card Action class to post question data.
  /// </summary>
  public class TrainingAdaptiveSubmitActionData : TeamsAdaptiveSubmitActionData
  {
    /// <summary>
    /// Gets or sets Updated question.
    /// </summary>
    [JsonProperty("knowledgebaseanswer")]
    public string KnowledgeBaseAnswer { get; set; }

  }
}
