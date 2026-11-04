List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Dust Crown", "Mars", 65),
    new Artifact("Cold Lens", "Europa", 28)
};


// TODO: Bruk Select til tre ulike projeksjoner.
var names = artifacts.Select(artifact => artifact.Name);
var risks = artifacts.Select(artifact => artifact.Risk);
var descriptions = artifacts.Select(artifact => $"{artifact.Name} ({artifact.Origin})");

foreach (var name in names)
{
    Console.WriteLine(name);
}

foreach (var risk in risks)
{
    Console.WriteLine(risk);
}

foreach (var description in descriptions)
{
    Console.WriteLine(description);
}