List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Dust Crown", "Mars", 65),
    new Artifact("Cold Lens", "Europa", 28)
};



var orderedArtifacts = artifacts
    .Where(artifact => artifact.Risk >= 30)
    .OrderBy(artifact => artifact.Name)
    .Select(artifact => $"{artifact.Name}: {artifact.Risk}");


foreach (var artifact in orderedArtifacts)
    {
        Console.WriteLine(artifact);
    }

var sortedByRisk = artifacts.OrderBy(artifact => artifact.Risk);

foreach (var artifact in sortedByRisk)
{
    Console.WriteLine($"{artifact.Name}: {artifact.Risk}");
}

// TODO: Where -> OrderBy -> Select.
// TODO: Lag også en egen OrderBy på Risk.
