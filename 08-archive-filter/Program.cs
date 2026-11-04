List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Dust Crown", "Mars", 65),
    new Artifact("Cold Lens", "Europa", 28)
};

var Risk = artifacts.Where(artifact => artifact.Risk >= 60);
        foreach (var artifact in Risk)
        {
            Console.WriteLine(artifact.Name);
        }

var moonArtifacts = artifacts.Where(artifact => artifact.Origin == "Moon");

        foreach (var artifact in moonArtifacts)
        {
              Console.WriteLine(artifact.Name);
        }

var e = artifacts.Where(artifact => artifact.Name.Contains("e", StringComparison.OrdinalIgnoreCase));

        foreach (var artifact in e)
        {
            Console.WriteLine(artifact.Name);
        }


// TODO: Lag tre separate Where-queries.
