ArtifactArchive archive = new ArtifactArchive();
archive.Add(new Artifact("Echo Stone", "Moon", 73));
archive.Add(new Artifact("Broken Compass", "Earth", 12));
archive.Add(new Artifact("Glass Seed", "Mars", 48));
archive.Add(new Artifact("Signal Cube", "Moon", 91));

var highRisk = archive.FindArtifacts(artifact => artifact.Risk >= 60);

foreach (var artifact in highRisk)
{
    Console.WriteLine($"{artifact.Name}: {artifact.Risk}");
}

var moonArtifacts = archive.FindArtifacts(artifact => artifact.Origin == "Moon");

foreach (var artifact in moonArtifacts)
{
    Console.WriteLine($"{artifact.Name}: {artifact.Origin}");
}

var nameContains = archive.FindArtifacts(artifact => artifact.Name.Contains("Stone"));

foreach (var artifact in nameContains)
{
    Console.WriteLine(artifact.Name);
}


// TODO: Kall FindArtifacts med minst tre forskjellige lambdas.

