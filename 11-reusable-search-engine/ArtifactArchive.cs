public class ArtifactArchive
{
    private List<Artifact> artifacts = new List<Artifact>();

    public void Add(Artifact artifact)
    {
        artifacts.Add(artifact);
    }

    public List<Artifact> FindArtifacts(Func<Artifact, bool> condition)
{
    return artifacts.Where(condition).ToList();
}
}
