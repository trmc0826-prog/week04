public class Artifact
{
    public string Name { get; set; }
    public string Origin { get; set; }
    public int Risk { get; set; }

    public Artifact(string name, string origin, int risk)
    {
        Name = name;
        Origin = origin;
        Risk = risk;
    }
}
public class ArtifactService
{
    private List<Artifact> artifacts;

    public ArtifactService(List<Artifact> artifacts)
    {
        this.artifacts = artifacts;
    }

    public List<Artifact> GetAll()
    {
        return new List<Artifact>(artifacts);
    }

    public List<Artifact> GetHighRisk()
    {
        return artifacts.Where(a => a.Risk >= 60).ToList();
    }

    public List<Artifact> SearchByOrigin(string origin)
    {
        return artifacts
            .Where(a => a.Origin.Equals(origin, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}
